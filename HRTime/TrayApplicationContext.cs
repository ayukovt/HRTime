using System.Windows.Forms;

namespace HRTime
{
	public class TrayApplicationContext : ApplicationContext
	{

		public TrayApplicationManager manager = new TrayApplicationManager();

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.manager.Dispose();
			}

			base.Dispose(disposing);
		}

	}

} //end of root namespace