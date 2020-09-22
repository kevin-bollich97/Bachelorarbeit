namespace MyNamespace
	{
	  public class MyClass
	  {
	    //NLog recommends using a static variable for the logger object
	    private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

		//NLog supports several logging levels, including INFO
		logger.Info("Hello {0}", "Earth");
		try
		{
			//Do something
		}
		catch (Exception ex)
		{
		    //Exceptions are typically logged at the ERROR level
		    logger.Error(ex, "Something bad happened");
		}
	  }
	}