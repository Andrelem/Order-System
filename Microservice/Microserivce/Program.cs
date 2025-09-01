namespace Microserivce
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            // Mostra uma mensagem simples com um bot�o OK e um �cone de informa��o
            DialogResult resultado = MessageBox.Show("Esta � a sua mensagem para o usu�rio.", "T�tulo da Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Verifica qual bot�o foi clicado pelo usu�rio
            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Voc� clicou em OK!");
            }


        }
    }
}