using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarkt
{
    public partial class Supermarkt : Form
    {
        Dictionary<string, int> shoppingList = new Dictionary<string, int>();
        string dictionaryPath = "C:\\Users\\DCV\\Desktop\\Coding\\04_Vertiefung_CSharp\\Supermarkt\\Supermarkt\\shoppingList.txt";

        public Supermarkt()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var item = tbItem.Text;
            var number = tbAmount.Text;
            int amount = Int32.Parse(tbAmount.Text);

            if (!string.IsNullOrEmpty(item) && (!string.IsNullOrEmpty(number)))
            {
                if (!shoppingList.ContainsKey(item))
                {
                    shoppingList.Add(item, amount);
                    updateShoppingList();
                    createShoppingListTxt();
                }
                else
                {
                    //jetzt erst mal nur die Anzahl geändert - noch nicht addiert bzw. subtrahiert
                    int result;

                   shoppingList.TryGetValue(item, out result);
                        amount += result;

                        shoppingList[item] = amount;
                    updateShoppingList();
                    createShoppingListTxt();
                }
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            var item = tbItem.Text;
            var number = tbAmount.Text;
            int amount = Int32.Parse(tbAmount.Text);

            if (!string.IsNullOrEmpty(item) && (!string.IsNullOrEmpty(number)))
            {
                int result;

                shoppingList.TryGetValue(item, out result);
                if (shoppingList.ContainsKey(item) && (result >= amount))
                {
                    amount = result - amount;
                    if (amount > 0)
                    {
                        shoppingList[item] = amount;
                        updateShoppingList();
                        createShoppingListTxt();
                    }
                    else
                    {
                        shoppingList.Remove(item);
                        updateShoppingList();
                        createShoppingListTxt();
                    }
                }
            }
        }
        private void createShoppingListTxt()
        {
            using (var writer = new StreamWriter(dictionaryPath))
            {
                foreach (var pair in shoppingList)
                {
                    writer.WriteLine("{0};{1};", pair.Key, pair.Value);
                }
            }
        }
        private void updateShoppingList()
        {
            List<string> list = new List<string>();
           
            foreach (KeyValuePair<string, int> pair in shoppingList)
            {
                string item = pair.Value.ToString() + "\t" + pair.Key;
                list.Add(item);
            }
            lBoxItems.DataSource = list.ToList();
        }

    }
}
