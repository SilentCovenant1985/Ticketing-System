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
  
  [fwInitialiseHandler()]
  internal class EnumHelper
  {
    static private bool s_firsttime = true;

    [fwPostInitialise()]
    static void fwFactory_PostInitialise()
    {
      if (s_firsttime == false)
        return;

      s_firsttime = false;

#if !NODBCHECK
      fwFactory.LogConsoleLine("Testing enum consistancy with database...", System.Diagnostics.EventLogEntryType.Information);
      string message = "";
		

      fwThread.CleanCache();
      if (message != "")
        throw new fwDataBaseException(message); 
#endif
        
      fwMember.GetEnumInstance = EnumHelper.GetInstance;
    }
    
    static public fwProxy GetInstance(Enum fwenumvalue)
    {
      string enumtype = fwenumvalue.GetType().ToString();

      throw new fwInvalidParameterException("you can only pass valid businessobject enums to this function");
    }

  }
		
}
