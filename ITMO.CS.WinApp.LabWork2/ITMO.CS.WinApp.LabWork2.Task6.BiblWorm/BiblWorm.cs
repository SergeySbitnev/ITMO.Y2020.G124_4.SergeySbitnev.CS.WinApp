using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CS.WinApp.LabWork2.Task6.BiblWorm
{
    public partial class BiblWorm : Form
    {
        List<Item> its = new List<Item>();

        public BiblWorm()
        {
            InitializeComponent();
        }

        public string Author //Автор
        {
            get { return textBoxAuthor.Text; }
            set { textBoxAuthor.Text = value; }
        }

        public string Title //Название
        {
            get { return textBoxTitle.Text; }
            set { textBoxTitle.Text = value; }
        }

        public string PublishHouse //Издательство
        {
            get { return textBoxPublishHouse.Text; }
            set { textBoxPublishHouse.Text = value; }
        }

        public int Page //Количество страниц
        {
            get { return (int)numericUpDownPage.Value;  }
            set { numericUpDownPage.Value = value; }
        }

        public int Year //Год издания 
        {
            get { return (int)numericUpDownYear.Value; }
            set { numericUpDownYear.Value = value; }
        }

        public int InvNumber //Ивертарный номер
        {
            get { return (int)numericUpDownInvNumber.Value; }
            set { numericUpDownInvNumber.Value = value; }
        }

        public bool Existence //Наличие
        {
            get { return checkBoxExistence.Checked; }
            set { checkBoxExistence.Checked = value; } 
        }

        public bool SortInvNumber //Сортировка по инвертарному номеру
        {
            get { return checkBoxSortInvNumber.Checked; }
            set { checkBoxSortInvNumber.Checked = value; }
        }

        public bool ReturnTime //Возвращение в срок
        {
            get { return checkBoxReturnTime.Checked; }
            set { checkBoxReturnTime.Checked = value; }
        }

        public int PeriodUse //Срок пользования
        {
            get { return (int)numericUpDownPeriodUse.Value; }
            set { numericUpDownPeriodUse.Value = value; }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Book newBook = new Book(Author, Title, PublishHouse, Page, Year, InvNumber, Existence);
            if (ReturnTime)
                newBook.ReturnSrok();
            newBook.PriceBook(PeriodUse);
            its.Add(newBook);
            Author = Title = PublishHouse = "";
            Year = PeriodUse = InvNumber = 0;
            Page = 1;
            Existence = ReturnTime = false;
        }

        private void buttonLock_Click(object sender, EventArgs e)
        {
            if (SortInvNumber)
                its.Sort();
            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }
            richTextBoxInfo.Text = sb.ToString();
        }
    }
}
