using Connect.Models;
using Connect.Properties;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Connect.classes.Api.Synchronisation
{
    internal class Synchronise
    {
        #region Variable and Object Declaration

        //server database connection for user details
        private static readonly ConnectPersonalServerEntities DbServer = new ConnectPersonalServerEntities();

        //local database connection for user details
        private static readonly ConnectOfflineDBEntities DbClient = new ConnectOfflineDBEntities();

        //local table connection for user details
        private static readonly User_Details_OfflineTable UserDetailsClient = new User_Details_OfflineTable();

        //server object
        private readonly Server _server;

        #endregion Variable and Object Declaration

        public Synchronise()
        {
            _server = new Server(Resources.LoggedInUserEmail);
        }

        public async void StartAsync()
        {
            await _server.GetDataAsync().ContinueWith((result) =>
            {
                DbClient.User_Details_OfflineTable.Add(result.Result);
                DbClient.SaveChanges();
            });
        }

        private class Server
        {
            private readonly string _email;

            public Server(string email)
            {
                _email = email;
            }

            public async Task<User_Details_OfflineTable> GetDataAsync()
            {
                User_Details_OfflineTable result = null;

                await ExtractDataAsync().ContinueWith(async (data) =>
                {
                    result = await MapDataAsync(data.Result);

                    return result;
                });

                return result;
            }

            /// <summary>
            ///Helps extract data from database
            /// </summary>
            /// <returns>user details as T1 and Account Type as T2</returns>
            private async Task<Tuple<User_Details, string>> ExtractDataAsync()
            {
                var data = await new Task<Tuple<User_Details, string>>(() =>
                {
                    try
                    {
                        #region extract specified data from UserDetails and Account Type Table and return it

                        var userDetailsQuery = from rows in DbServer.User_Details
                                               where rows.vcEmail == _email
                                               select rows;

                        var accountTypeQuery = (from rows in DbServer.Account_Type
                                                where rows.iA_Tid == userDetailsQuery.FirstOrDefault().iFK_AccountTypeId
                                                select rows.vcType.SingleOrDefault()).ToString();

                        return new Tuple<User_Details, string>(userDetailsQuery.SingleOrDefault(), accountTypeQuery);

                        #endregion extract specified data from UserDetails and Account Type Table and return it
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                });
                return data;
            }

            private async Task<User_Details_OfflineTable> MapDataAsync(Tuple<User_Details, string> data)
            {
                var mappedData = await new Task<User_Details_OfflineTable>(() =>
                {
                    try
                    {
                        #region map data

                        var @dataTuple = data;

                        UserDetailsClient.vcFirstName = @dataTuple.Item1.vcFirstName;
                        UserDetailsClient.vcLastName = @dataTuple.Item1.vcLastName;
                        UserDetailsClient.vcEmail = @dataTuple.Item1.vcEmail;
                        UserDetailsClient.vcAddress = @dataTuple.Item1.vcAddress;

                        var offlineAccountTypeQuery = (from accType in DbClient.Account_Type_OfflineTable
                                                       where accType.vcType == @dataTuple.Item2
                                                       select accType.iA_Tid).SingleOrDefault();

                        var accountTypes = from accType in DbClient.Account_Type_OfflineTable
                                           select accType;

                        if (accountTypes.ToLookup(table => table.iA_Tid).Contains(offlineAccountTypeQuery))
                        {
                            UserDetailsClient.iFK_AccountTypeId = offlineAccountTypeQuery;
                        }
                        else
                        {
                            var accountTypeOfflineTable = accountTypes.ToList()
                                .SingleOrDefault(cd => cd.vcType.ToLower().Equals("buyer"));

                            UserDetailsClient.iFK_AccountTypeId = accountTypeOfflineTable != null
                                ? accountTypeOfflineTable.iA_Tid
                                : 1;
                        }
                        return UserDetailsClient;

                        #endregion map data
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                });

                return mappedData;
            }
        }

        private static async Task<bool> DownloadImageAsync(int pictureId)
        {
            WebClient client = new WebClient();

            var isCompleted = false;

            await client.DownloadFileTaskAsync(new Uri(
                String.Format("{0}/{1}.jpg", Resources.ServerPictureFolder, pictureId)),
                String.Format("{0}.jpg", pictureId)
                ).ContinueWith((res) =>
            {
                isCompleted = res.IsCompleted;
            });

            return isCompleted;
        }
    }
}