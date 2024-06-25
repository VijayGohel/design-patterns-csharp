using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ArticleDialogBox : DialogBox
    {

        private ListBox articleListBox;
        private TextBox titleTextBox;
        private Button saveButton;
        public ArticleDialogBox()
        {
            this.articleListBox = new ListBox(this);
            this.titleTextBox = new TextBox(this);
            this.saveButton = new Button(this);
        }

        public override void Changed(UIControl control)
        {
            if (control == articleListBox)
            {
                ArticleSelected();
            }
            else if (control == titleTextBox) 
            {
                TitleChanged();
            }
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
