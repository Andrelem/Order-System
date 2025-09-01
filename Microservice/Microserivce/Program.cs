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
            // Mostra uma mensagem simples com um botão OK e um ícone de informação
            DialogResult resultado = MessageBox.Show("Esta é a sua mensagem para o usuário.", "Título da Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Verifica qual botão foi clicado pelo usuário
            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Você clicou em OK!");
            }


        }
    }
}