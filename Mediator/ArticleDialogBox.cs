using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ArticleDialogBox
    {
        public class ListBoxObserver : Observer
        {
            ArticleDialogBox articleDialog;
            public ListBoxObserver(ArticleDialogBox articleDialog)
            {
                this.articleDialog = articleDialog;
            }
            public void Update()
            {
                this.articleDialog.ArticleSelected();
            }
        }

        public class TextBoxObserver : Observer
        {
            ArticleDialogBox articleDialog;
            public TextBoxObserver(ArticleDialogBox articleDialog)
            {
                this.articleDialog = articleDialog;
            }
            public void Update()
            {
                this.articleDialog.TitleChanged();
            }
        }

        private ListBox articleListBox;
        private TextBox titleTextBox;
        private Button saveButton;
        public ArticleDialogBox()
        {
            this.articleListBox = new ListBox();
            this.titleTextBox = new TextBox();
            this.saveButton = new Button();

            this.articleListBox.AddObserver(new ListBoxObserver(this));
            this.titleTextBox.AddObserver(new TextBoxObserver(this));
        }

        private void ArticleSelected()
        {
            titleTextBox.Content = articleListBox.Selection;
            saveButton.IsEnable = true;
        }

        private void TitleChanged()
        {
            saveButton.IsEnable = !string.IsNullOrEmpty(titleTextBox.Content);
        }

        public void SimulateUserInteraction()
        {
            articleListBox.Selection = "Article 1";
            titleTextBox.Content = string.Empty;
            articleListBox.Selection = "Article 2";
            Console.WriteLine("TextBox: "+titleTextBox.Content);
            Console.WriteLine("Button: "+saveButton.IsEnable);
        }
    }
}
