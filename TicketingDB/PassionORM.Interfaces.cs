// PassionORM generation version stamp: [+MydN6z8oiisM5eQUVg0fA4xMZA=]


using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Runtime.Serialization;
using System.Diagnostics;

using PassionORM;
using PassionORM.Translation;
using PassionORM.Threading;
using PassionORM.Data;
using PassionORM.Data.Design;

namespace PassionORM.BusinessObjects
{
  
    #region "Threading"

    [fwInitialiseHandler()]
    public static class ThreadHelper
    {
      static fwBoolean IsSubscribed = null;

      [fwPostInitialise()]
      static void fwFactory_PostInitialise()
      {
        fwThread.SecureInit<fwBoolean>(ref IsSubscribed,
          delegate()
          {
            fwThread.CleanUpWork += new fwThread.fwThreadCleanUpWork(Cleanup);
            return true;
          });
      }
      public static void Cleanup(bool AlsoStaticCache)
      {
        Categories.data_Categories.Clean(AlsoStaticCache);
        Events.data_Events.Clean(AlsoStaticCache);
        Requests.data_Requests.Clean(AlsoStaticCache);
        Users.data_Users.Clean(AlsoStaticCache);
        
      }
    }

#endregion

}
