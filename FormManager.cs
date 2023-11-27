namespace GolbinsAndGui
{
    internal class FormManager : ApplicationContext
    {
        private static Lazy<FormManager> _current = new Lazy<FormManager>();
        public static FormManager Current => _current.Value;
        public FormManager()
        {
            var f1 = CreateForm<setupChar>(); //create character
            f1.Show();
            //var f2 = CreateForm<Form1>(); //dialouge
            //f2.Show();
        }
        private void onFormClosed(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                ExitThread();
            }
        }

        public T CreateForm<T>() where T : Form, new()
        {
            var ret = new T();
            ret.FormClosed += onFormClosed;
            return ret;
        }
    }
}
