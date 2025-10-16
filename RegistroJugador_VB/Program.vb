Imports System
Imports System.Windows.Forms

Namespace RegistroJugador_VB
    Friend Module Program
        <STAThread>
        Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New FrmRegistroJugador())
        End Sub
    End Module
End Namespace
