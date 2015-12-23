using System;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using Dorothy.Utils;
using Dorothy.Data;
using Dorothy.UI;

namespace Dorothy
{
  static class Program
  {
    //-------------------------------------------------------------------------

    public static Log Log { get; private set; }
    public static Project Project { get; private set; }

    //-------------------------------------------------------------------------

    [STAThread]
    static void Main( string[] args )
    {
      // Initialise the log.
      Log =
        new Log(
          Path.GetDirectoryName( Assembly.GetExecutingAssembly().FullName ) + "Dorothy.log",
          1000 );

      // Load the project.
      Project = new Project();

      if( args.Length > 0 )
      {
        if( Project.LoadFromFile( args[ 0 ] ) == false )
        {
          MessageBox.Show(
            "Failed to load project '" + args[ 0 ] + "'.",
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error );
        }
      }

      // Start the app.
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault( false );
      Application.Run( new MainForm() );

      // Shutdown.
      Log.AddInfo( "Shutdown." );
    }

    //-------------------------------------------------------------------------
  }
}
