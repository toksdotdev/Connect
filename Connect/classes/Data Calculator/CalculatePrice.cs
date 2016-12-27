using Connect.Properties;
using System;

namespace Connect.classes.Data_Calculator
{
    internal class CalculatePrice
    {
        private double Price { get; set; }
        private int Gigabytes { get; set; }
        private int Megabytes { get; set; }

        //private int Price { get; set; }

        public CalculatePrice(double amountOfData)
        {
            Gigabytes = 0;

            int pricePer100Mb = Convert.ToInt32(Resources.PricePer100MB);

            if (amountOfData < 100)
            {
                //then selected data is of size gigabyte
                this.Gigabytes = Convert.ToInt32(amountOfData.ToString().Split('.')[0]);

                //calculate the gigabyte price
                Price = (this.Gigabytes * 10) * pricePer100Mb;

                //calculate the megabyte price
                //string str = String.Format("{0:D}", amountOfData);
                string str = String.Format("{0:0.00}", amountOfData);

                if (!((str.Contains(".0")) || str.Contains(".00")))
                {
                    this.Megabytes = Convert.ToInt32(amountOfData.ToString().Split('.')[1]);

                    Price += this.Megabytes * pricePer100Mb;
                }
            }
            else
            {
                //selected data is of size megabyte
                Price = (amountOfData / 100) * pricePer100Mb;
            }
        }

        public double GetPrice()
        {
            return this.Price;
        }

        public override string ToString()
        {
            //returns value as money format e.g. N500,000
            string text = this.ReverseString(Price.ToString());

            string newText = " ";

            for (int i = 0; i < text.Length; i += 3)
            {
                if ((text.Length - i) < 3)
                {
                    int rem = ((text.Length) % 3);
                    newText += String.Format("{0}", text.Substring(i, rem));
                }
                else if (text.Length == 3)
                    newText += String.Format("{0}", text.Substring(i, 3));
                else
                    newText += String.Format("{0},", text.Substring(i, 3));
            }

            newText = newText.Trim();
            newText = this.ReverseString(newText);

            return newText;
        }

        private string ReverseString(string str)
        {
            //if (str.Length <= 1)
            //    return str;
            //else
            //    return ReverseString(str.Substring(1) + str[0]);

            char[] chars = new char[str.Length];

            for (int i = 0, j = str.Length - 1; i <= j; i++, j--)
            {
                chars[i] = str[j];
                chars[j] = str[i];
            }

            return new string(chars);
        }
    }
}