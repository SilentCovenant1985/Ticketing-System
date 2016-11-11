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
  
#region "Class: Categories"

#if !DEBUG
[DebuggerStepThrough()]
#endif
[Serializable]
public partial class Categories : fwProxy<Categories, Categories.data_Categories, fwInt32>, fwInnerObject<Categories.data_Categories>
{

  #region " ISerializable Members "

  protected Categories(SerializationInfo info, StreamingContext context)
  {
    base.DeSerialize(info, context);
  }

  #endregion
  #region Class Comparison and Default Translation

	static Categories()
	{
		fwFactory.Initialise();
		
	}
    
	// Rendered for Extra Comfort
	public Categories() : base() { }
	[Obsolete("Please use: new Categories();", true)]
	public Categories(bool initialize) : base(initialize) { }

	public Categories(fwInt32 CategoryID) : base(CategoryID) { }
	public Categories(int CategoryID) : base((fwInt32)CategoryID) { }

    public Categories(fwExpression expression) : base(expression) { }
    internal Categories(data_Categories data) : base(data) { }


    new public static Categories TryLoad(fwInt32 CategoryID)
    {
      return fwProxy<Categories, Categories.data_Categories, fwInt32>.TryLoad(CategoryID);
    }
    public static Categories TryLoad(int CategoryID)
    {
      return fwProxy<Categories, Categories.data_Categories, fwInt32>.TryLoad((fwInt32)CategoryID);
    }


    new public static Categories TryLoad(fwExpression expression)
    {
      return fwProxy<Categories, Categories.data_Categories, fwInt32>.TryLoad(expression);
    }

    public static bool operator ==(Categories a, Categories b)
    {
      if (((object)a == null) && ((object)b == null)) { return true; }
      if ((object)a == null)
        return b.InnerDataObject.Equals(a);
      else
        return a.InnerDataObject.Equals(b);
    }
	  public static bool operator !=(Categories a, Categories b)
    {
		  if (((object)a == null) && ((object)b == null)) { return false; }
		  if ((object)a == null)
  			return !b.InnerDataObject.Equals(a);
		  else
  			return !a.InnerDataObject.Equals(b);
    }
  	public static fwExpression operator ==(fwMember a, Categories b)
    {
  	  if ((object)b == null)
        return new fwExpression(a, fwOperator.opEqual, (fwObject)null);
      else
        return new fwExpression(a, fwOperator.opEqual, b.InnerDataObject);
    }
  	public static fwExpression operator !=(fwMember a, Categories b)
    {
  	  if ((object)b == null)
        return new fwExpression(a, fwOperator.opNotEqual, (fwObject)null);
      else
        return new fwExpression(a, fwOperator.opNotEqual, b.InnerDataObject);
    }
    public override bool Equals(object obj) { return InnerDataObject.Equals(obj); }
    public override int GetHashCode() { return InnerDataObject.GetHashCode(); }



    public static CategoriesCollection All
    {
      get
      {
        CategoriesCollection tmp = new CategoriesCollection(false);
        return tmp;
      }
    }
	  public static CategoriesCollection AllEx(fwExpression expression)
	  {
		  return new CategoriesCollection(expression, true);
	  }

  	public static class Members
	  {
	
      private static fwMember m_CategoryID = null;
      public static fwMember CategoryID
      {
        get
        {
          fwThread.SecureInit<fwMember>(ref m_CategoryID, delegate() { return Categories.Class.Members["CategoryID"]; });
          return m_CategoryID;
        }
      }
		
      private static fwMember m_CategoryName = null;
      public static fwMember CategoryName
      {
        get
        {
          fwThread.SecureInit<fwMember>(ref m_CategoryName, delegate() { return Categories.Class.Members["CategoryName"]; });
          return m_CategoryName;
        }
      }
		
      private static fwMember m_CategoryDescriptoin = null;
      public static fwMember CategoryDescriptoin
      {
        get
        {
          fwThread.SecureInit<fwMember>(ref m_CategoryDescriptoin, delegate() { return Categories.Class.Members["CategoryDescriptoin"]; });
          return m_CategoryDescriptoin;
        }
      }
		
      private static fwCollectionMember m_Requestses = null;
      public static fwCollectionMember Requestses
      {
        get
        {
          fwThread.SecureInit<fwCollectionMember>(ref m_Requestses, delegate() { return Categories.Class.CollectionMembers["Requestses"]; });
          return m_Requestses;
        }
      }
		
	  }



#endregion


#if !DEBUG
    [fwClass("Live", "Categories", "m_CategoryID", null, IsDynamicData = false, DBGen = "PassionORM")]
    [DebuggerStepThrough()]
#else
    [fwClass("Development", "Categories", "m_CategoryID", null, IsDynamicData = false, DBGen = "PassionORM")]
#endif
    [Serializable]
    public partial class data_Categories : fwObject<Categories, data_Categories, fwInt32>
    {

#region " ISerializable Members "

      protected data_Categories(SerializationInfo info, StreamingContext context)
      {
        base.DeSerialize(info, context);
      }

#endregion
#region Framework Key Access Routines

  	  // Rendered for Extra Speed
    
      public data_Categories() : base() { }
      internal data_Categories(Categories parent) : base()
      {
        DefaultParent = parent;
      }
    
      protected override fwType GetKeyValue()
      {
        return m_CategoryID;
      }
      protected override fwInt32 GetKeyValueTyped()
      {

        return m_CategoryID;
	
      }
      protected override void SetKeyValue(fwType value)
      {

        m_PersistenceState = fwObjectStatus.ExistingDirty;
        m_CategoryID = value as fwInt32;
	
      }

	    protected override void SetValueAsRecordIndex(int MyRecordIndex, IDataRecord MyRecord)
      {
        if (MyRecord.IsDBNull(MyRecordIndex) == true)
        {
          m_PersistenceState = fwObjectStatus.New; 
          m_CategoryID = null;
        }
        else
        {
          m_PersistenceState = fwObjectStatus.ExistingDirty; 
          m_CategoryID = new fwInt32(MyRecord.GetInt32(MyRecordIndex));
        }
      }

      public static fwCollection All()
      {
        fwCollection tmp = ((fwInnerCollection)new CategoriesCollection(false)).GetInnerCollection();
        return tmp;
      }

      public override Categories DefaultParent
      {
        get
        {
          if ((object)m_DefaultParent == null)
            m_DefaultParent = new Categories(this);
          return m_DefaultParent;
        }
        set
        {
          if ((object)m_DefaultParent == null)
            m_DefaultParent = value;
        }
      }
#endregion
		
		
#region "Member: CategoryID"

	[fwMember("CategoryID" 
		, Name = "CategoryID"
		, Order = 1
		, IsHidden = true 
		, IsReadOnly = false
		, IsNullable = false
		, HasRemoteValue = false
		, IsUnique = true
		, CaseSensitive = true
		, Length = 4
		, HasTranslation = false
		)]
	
	public fwInt32 m_CategoryID = null;
				
			
#endregion
			
#region "Member: CategoryName"

	[fwMember("CategoryName" 
		, Name = "CategoryName"
		, Order = 2
		, IsHidden = false 
		, IsReadOnly = false
		, IsNullable = false
		, HasRemoteValue = false
		, IsUnique = false
		, CaseSensitive = false
		, Length = 50
		, HasTranslation = false
		)]
	
	public fwString m_CategoryName = null;
				
			
#endregion
			
#region "Member: CategoryDescriptoin"

	[fwMember("CategoryDescriptoin" 
		, Name = "CategoryDescriptoin"
		, Order = 3
		, IsHidden = false 
		, IsReadOnly = false
		, IsNullable = true
		, HasRemoteValue = false
		, IsUnique = false
		, CaseSensitive = false
		, Length = 1000
		, HasTranslation = false
		)]
	
	public fwString m_CategoryDescriptoin = null;
				
			
#endregion
			
#region "Member: Requestses"

	[fwCollectionMember("Categories_CategoryID"
		, Name = "Requestses"
		, Order = 4
		, IsHidden = false 
		, IsReadOnly = false
		, IsNullable = false
		, IsUnique = false
	)]
	
	public RequestsCollection.data_RequestsCollection m_Requestses = null;

#endregion
			

	  }
#region "Members"
		
#region "Member: CategoryID"
/// <summary></summary>
    public fwInt32 CategoryID
  	{
	  	get
		  {
  		  return InnerDataObject.m_CategoryID;
		  }
		  set
		  {
          if (InnerDataObject.PersistenceState != fwObjectStatus.New && InnerDataObject.PersistenceState != fwObjectStatus.NewChanged)
            throw new fwFunctionalException("You can not change the object it's key");
      
          InnerDataObject.LoadIfDirty();
	  	  if (InnerDataObject.m_CategoryID != value)
        {
			    InnerDataObject.PropertyChange();
          InnerDataObject.m_CategoryID = value;
        }
		  }
	  }

#endregion
		
#region "Member: CategoryName"
/// <summary></summary>
    public fwString CategoryName
  	{
	  	get
		  {
  		  InnerDataObject.LoadIfDirty(); return InnerDataObject.m_CategoryName;
		  }
		  set
		  {
          InnerDataObject.LoadIfDirty();
	  	  if (InnerDataObject.m_CategoryName != value)
        {
			    InnerDataObject.PropertyChange();
          InnerDataObject.m_CategoryName = value;
        }
		  }
	  }

#endregion
		
#region "Member: CategoryDescriptoin"
/// <summary></summary>
    public fwString CategoryDescriptoin
  	{
	  	get
		  {
  		  InnerDataObject.LoadIfDirty(); return InnerDataObject.m_CategoryDescriptoin;
		  }
		  set
		  {
          InnerDataObject.LoadIfDirty();
	  	  if (InnerDataObject.m_CategoryDescriptoin != value)
        {
			    InnerDataObject.PropertyChange();
          InnerDataObject.m_CategoryDescriptoin = value;
        }
		  }
	  }

#endregion
		
#region "Member: Requestses"
/// <summary></summary>
    public RequestsCollection RequestsesEx()
    {
      return RequestsesEx(null);
    }
    /// <summary></summary>
    public RequestsCollection RequestsesEx(fwExpression expression)
    {
      return CollectionGet<RequestsCollection, Requests>(this, expression, true, Categories.Members.CategoryID, Requests.Members.Categories_Category);
    }

    /// <summary></summary>
    public Requests RequestsEx(fwExpression expression)
    {
      if ((object)InnerDataObject.m_CategoryID == null)
        return null;
      RequestsCollection tmp = CollectionGet<RequestsCollection, Requests>(this, expression, true, Categories.Members.CategoryID, Requests.Members.Categories_Category);
      tmp.MaxLength = 1;
      if (tmp.Count == 0)
        return null;
      else
        return tmp[0];
    }
    /// <summary></summary>
    public Requests RequestsEx()
    {
      if ((object)InnerDataObject.m_CategoryID == null) { return null; }
      return Requests.TryLoad(new fwExpression(Requests.Members.Categories_Category, fwOperator.opEqual, (fwType)InnerDataObject.m_CategoryID));
    }

#endregion
		
#endregion

#region "Interface Members"
    
#endregion

    
  }
#endregion
  
#region "Class: Events"

#if !DEBUG
[DebuggerStepThrough()]
#endif
[Serializable]
public partial class Events : fwProxy<Events, Events.data_Events, fwInt32>, fwInnerObject<Events.data_Events>
{

  #region " ISerializable Members "

  protected Events(SerializationInfo info, StreamingContext context)
  {
    base.DeSerialize(info, context);
  }

  #endregion
  #region Class Comparison and Default Translation

	static Events()
	{
		fwFactory.Initialise();
		
	}
    
	// Rendered for Extra Comfort
	public Events() : base() { }
	[Obsolete("Please use: new Events();", true)]
	public Events(bool initialize) : base(initialize) { }

	public Events(fwInt32 EventID) : base(EventID) { }
	public Events(int EventID) : base((fwInt32)EventID) { }

    public Events(fwExpression expression) : base(expression) { }
    internal Events(data_Events data) : base(data) { }


    new public static Events TryLoad(fwInt32 EventID)
    {
      return fwProxy<Events, Events.data_Events, fwInt32>.TryLoad(EventID);
    }
    public static Events TryLoad(int EventID)
    {
      return fwProxy<Events, Events.data_Events, fwInt32>.TryLoad((fwInt32)EventID);
    }


    new public static Events TryLoad(fwExpression expression)
    {
      return fwProxy<Events, Events.data_Events, fwInt32>.TryLoad(expression);
    }

    public static bool operator ==(Events a, Events b)
    {
      if (((object)a == null) && ((object)b == null)) { return true; }
      if ((object)a == null)
        return b.InnerDataObject.Equals(a);
      else
        return a.InnerDataObject.Equals(b);
    }
	  public static bool operator !=(Events a, Events b)
    {
		  if (((object)a == null) && ((object)b == null)) { return false; }
		  if ((object)a == null)
  			return !b.InnerDataObject.Equals(a);
		  else
  			return !a.InnerDataObject.Equals(b);
    }
  	public static fwExpression operator ==(fwMember a, Events b)
    {
  	  if ((object)b == null)
        return new fwExpression(a, fwOperator.opEqual, (fwObject)null);
      else
        return new fwExpression(a, fwOperator.opEqual, b.InnerDataObject);
    }
  	public static fwExpression operator !=(fwMember a, Events b)
    {
  	  if ((object)b == null)
        return new fwExpression(a, fwOperator.opNotEqual, (fwObject)null);
      else
        return new fwExpression(a, fwOperator.opNotEqual, b.InnerDataObject);
    }
    public override bool Equals(object obj) { return InnerDataObject.Equals(obj); }
    public override int GetHashCode() { return InnerDataObject.GetHashCode(); }



    public static EventsCollection All
    {
      get
      {
        EventsCollection tmp = new EventsCollection(false);
        return tmp;
      }
    }
	  public static EventsCollection AllEx(fwExpression expression)
	  {
		  return new EventsCollection(expression, true);
	  }

  	public static class Members
	  {
	
      private static fwMember m_EventID = null;
      public static fwMember EventID
      {
        get
        {
          fwThread.SecureInit<fwMember>(ref m_EventID, delegate() { return Events.Class.Members["EventID"]; });
          return m_EventID;
        }
      }
		
      private static fwMember m_EventDate = null;
      public static fwMember EventDate
      {
        get
        {
          fwThread.SecureInit<fwMember>(ref m_EventDate, delegate() { return Events.Class.Members["EventDate"]; });
          return m_EventDate;
        }
      }
		
      private static fwMember m_RequestStatusChange = null;
      public static fwMember RequestStatusChange
      {
        get
        {
          fwThread.SecureInit<fwMember>(ref m_RequestStatusChange, delegate() { return Events.Class.Members["RequestStatusChange"]; });
          return m_RequestStatusChange;
        }
      }
		
      private static fwMember m_RequestDescription = null;
      public static fwMember RequestDescription
      {
        get
        {
          fwThread.SecureInit<fwMember>(ref m_RequestDescription, delegate() { return Events.Class.Members["RequestDescription"]; });
          return m_RequestDescription;
        }
      }
		
      private static fwMember m_EventDescription = null;
      public static fwMember EventDescription
      {
        get
        {
          fwThread.SecureInit<fwMember>(ref m_EventDescription, delegate() { return Events.Class.Members["EventDescription"]; });
          return m_EventDescription;
        }
      }
		
      private static fwMember m_Requests_Request = null;
      public static fwMember Requests_Request
      {
        get
        {
          fwThread.SecureInit<fwMember>(ref m_Requests_Request, delegate() { return Events.Class.Members["Requests_Request"]; });
          return m_Requests_Request;
        }
      }
		
	  }



#endregion


#if !DEBUG
    [fwClass("Live", "Events", "m_EventID", null, IsDynamicData = true, DBGen = "PassionORM")]
    [DebuggerStepThrough()]
#else
    [fwClass("Development", "Events", "m_EventID", null, IsDynamicData = true, DBGen = "PassionORM")]
#endif
    [Serializable]
    public partial class data_Events : fwObject<Events, data_Events, fwInt32>
    {

#region " ISerializable Members "

      protected data_Events(SerializationInfo info, StreamingContext context)
      {
        base.DeSerialize(info, context);
      }

#endregion
#region Framework Key Access Routines

  	  // Rendered for Extra Speed
    
      public data_Events() : base() { }
      internal data_Events(Events parent) : base()
      {
        DefaultParent = parent;
      }
    
      protected override fwType GetKeyValue()
      {
        return m_EventID;
      }
      protected override fwInt32 GetKeyValueTyped()
      {

        return m_EventID;
	
      }
      protected override void SetKeyValue(fwType value)
      {

        m_PersistenceState = fwObjectStatus.ExistingDirty;
        m_EventID = value as fwInt32;
	
      }

	    protected override void SetValueAsRecordIndex(int MyRecordIndex, IDataRecord MyRecord)
      {
        if (MyRecord.IsDBNull(MyRecordIndex) == true)
        {
          m_PersistenceState = fwObjectStatus.New; 
          m_EventID = null;
        }
        else
        {
          m_PersistenceState = fwObjectStatus.ExistingDirty; 
          m_EventID = new fwInt32(MyRecord.GetInt32(MyRecordIndex));
        }
      }

      public static fwCollection All()
      {
        fwCollection tmp = ((fwInnerCollection)new EventsCollection(false)).GetInnerCollection();
        return tmp;
      }

      public override Events DefaultParent
      {
        get
        {
          if ((object)m_DefaultParent == null)
            m_DefaultParent = new Events(this);
          return m_DefaultParent;
        }
        set
        {
          if ((object)m_DefaultParent == null)
            m_DefaultParent = value;
        }
      }
#endregion
		
		
#region "Member: EventID"

	[fwMember("EventID" 
		, Name = "EventID"
		, Order = 1
		, IsHidden = true 
		, IsReadOnly = false
		, IsNullable = false
		, HasRemoteValue = false
		, IsUnique = true
		, CaseSensitive = true
		, Length = 4
		, HasTranslation = false
		)]
	
	public fwInt32 m_EventID = null;
				
			
#endregion
			
#region "Member: EventDate"

	[fwMember("EventDate" 
		, Name = "EventDate"
		, Order = 2
		, IsHidden = false 
		, IsReadOnly = false
		, IsNullable = false
		, HasRemoteValue = false
		, IsUnique = false
		, CaseSensitive = true
		, Length = 8
		, HasTranslation = false
		)]
	
	public fwDateTime m_EventDate = null;
				
			
#endregion
			
#region "Member: RequestStatusChange"

	[fwMember("RequestStatusChange" 
		, Name = "RequestStatusChange"
		, Order = 3
		, IsHidden = false 
		, IsReadOnly = false
		, IsNullable = false
		, HasRemoteValue = false
		, IsUnique = false
		, CaseSensitive = false
		, Length = 50
		, HasTranslation = false
		)]
	
	public fwString m_RequestStatusChange = null;
				
			
#endregion
			
#region "Member: RequestDescription"

	[fwMember("RequestDescription" 
		, Name = "RequestDescription"
		, Order = 4
		, IsHidden = false 
		, IsReadOnly = false
		, IsNullable = false
		, HasRemoteValue = false
		, IsUnique = false
		, CaseSensitive = false
		, Length = 1000
		, HasTranslation = false
		)]
	
	public fwString m_RequestDescription = null;
				
			
#endregion
			
#region "Member: EventDescription"

	[fwMember("EventDescription" 
		, Name = "EventDescription"
		, Order = 5
		, IsHidden = false 
		, IsReadOnly = false
		, IsNullable = false
		, HasRemoteValue = false
		, IsUnique = false
		, CaseSensitive = false
		, Length = 1000
		, HasTranslation = false
		)]
	
	public fwString m_EventDescription = null;
				
			
#endregion
			
#region "Member: Requests_Request"

	[fwMember("Requests_RequestID" 
		, Name = "Requests_Request"
		, Order = 6
		, IsHidden = false 
		, IsReadOnly = false
		, IsNullable = false
		, HasRemoteValue = false
		, IsUnique = false
		, CaseSensitive = true
		, Length = 4
		, HasTranslation = false
		)]
	
	public Requests.data_Requests m_Requests_Request = null;
			
#endregion
			

	  }
#region "Members"
		
#region "Member: EventID"
/// <summary></summary>
    public fwInt32 EventID
  	{
	  	get
		  {
  		  return InnerDataObject.m_EventID;
		  }
		  set
		  {
          if (InnerDataObject.PersistenceState != fwObjectStatus.New && InnerDataObject.PersistenceState != fwObjectStatus.NewChanged)
            throw new fwFunctionalException("You can not change the object it's key");
      
          InnerDataObject.LoadIfDirty();
	  	  if (InnerDataObject.m_EventID != value)
        {
			    InnerDataObject.PropertyChange();
          InnerDataObject.m_EventID = value;
        }
		  }
	  }

#endregion
		
#region "Member: EventDate"
/// <summary></summary>
    public fwDateTime EventDate
  	{
	  	get
		  {
  		  InnerDataObject.LoadIfDirty(); return InnerDataObject.m_EventDate;
		  }
		  set
		  {
          InnerDataObject.LoadIfDirty();
	  	  if (InnerDataObject.m_EventDate != value)
        {
			    InnerDataObject.PropertyChange();
          InnerDataObject.m_EventDate = value;
        }
		  }
	  }

#endregion
		
#region "Member: RequestStatusChange"
/// <summary></summary>
    public fwString RequestStatusChange
  	{
	  	get
		  {
  		  InnerDataObject.LoadIfDirty(); return InnerDataObject.m_RequestStatusChange;
		  }
		  set
		  {
          InnerDataObject.LoadIfDirty();
	  	  if (InnerDataObject.m_RequestStatusChange != value)
        {
			    InnerDataObject.PropertyChange();
          InnerDataObject.m_RequestStatusChange = value;
        }
		  }
	  }

#endregion
		
#region "Member: RequestDescription"
/// <summary></summary>
    public fwString RequestDescription
  	{
	  	get
		  {
  		  InnerDataObject.LoadIfDirty(); return InnerDataObject.m_RequestDescription;
		  }
		  set
		  {
          InnerDataObject.LoadIfDirty();
	  	  if (InnerDataObject.m_RequestDescription != value)
        {
			    InnerDataObject.PropertyChange();
          InnerDataObject.m_RequestDescription = value;
        }
		  }
	  }

#endregion
		
#region "Member: EventDescription"
/// <summary></summary>
    public fwString EventDescription
  	{
	  	get
		  {
  		  InnerDataObject.LoadIfDirty(); return InnerDataObject.m_EventDescription;
		  }
		  set
		  {
          InnerDataObject.LoadIfDirty();
	  	  if (InnerDataObject.m_EventDescription != value)
        {
			    InnerDataObject.PropertyChange();
          InnerDataObject.m_EventDescription = value;
        }
		  }
	  }

#endregion
		
#region "Member: Requests_Request"
/// <summary></summary>        
    public Requests Requests_Request
    {
      get
      {
        return LookupGet<Requests, Requests.data_Requests>(this, Events.Members.Requests_Request);
      }
      set
      {
        LookupSet<Events, Events.data_Events, Requests, EventsCollection, EventsCollection.data_EventsCollection>(this.InnerDataObject, value, Events.Members.Requests_Request, Requests.Class.CollectionMembers["Eventses"], Events.Members.EventID, Events.Members.Requests_Request);
      }
    }
			
#endregion
		
#endregion

#region "Interface Members"
    
#endregion

    
  }
#endregion
  
#region "Class: Requests"

#if !DEBUG
[DebuggerStepThrough()]
#endif
[Serializable]
public partial class Requests : fwProxy<Requests, Requests.data_Requests, fwInt32>, fwInnerObject<Requests.data_Requests>
{

  #region " ISerializable Members "

  protected Requests(SerializationInfo info, StreamingContext context)
  {
    base.DeSerialize(info, context);
  }

  #endregion
  #region Class Comparison and Default Translation

	static Requests()
	{
		fwFactory.Initialise();
		
	}
    
	// Rendered for Extra Comfort
	public Requests() : base() { }
	[Obsolete("Please use: new Requests();", true)]
	public Requests(bool initialize) : base(initialize) { }

	public Requests(fwInt32 RequestID) : base(RequestID) { }
	public Requests(int RequestID) : base((fwInt32)RequestID) { }

    public Requests(fwExpression expression) : base(expression) { }
    internal Requests(data_Requests data) : base(data) { }


    new public static Requests TryLoad(fwInt32 RequestID)
    {
      return fwProxy<Requests, Requests.data_Requests, fwInt32>.TryLoad(RequestID);
    }
    public static Requests TryLoad(int RequestID)
    {
      return fwProxy<Requests, Requests.data_Requests, fwInt32>.TryLoad((fwInt32)RequestID);
    }


    new public static Requests TryLoad(fwExpression expression)
    {
      return fwProxy<Requests, Requests.data_Requests, fwInt32>.TryLoad(expression);
    }

    public static bool operator ==(Requests a, Requests b)
    {
      if (((object)a == null) && ((object)b == null)) { return true; }
      if ((object)a == null)
        return b.InnerDataObject.Equals(a);
      else
        return a.InnerDataObject.Equals(b);
    }
	  public static bool operator !=(Requests a, Requests b)
    {
		  if (((object)a == null) && ((object)b == null)) { return false; }
		  if ((object)a == null)
  			return !b.InnerDataObject.Equals(a);
		  else
  			return !a.InnerDataObject.Equals(b);
    }
  	public static fwExpression operator ==(fwMember a, Requests b)
    {
  	  if ((object)b == null)
        return new fwExpression(a, fwOperator.opEqual, (fwObject)null);
      else
        return new fwExpression(a, fwOperator.opEqual, b.InnerDataObject);
    }
  	public static fwExpression operator !=(fwMember a, Requests b)
    {
  	  if ((object)b == null)
        return new fwExpression(a, fwOperator.opNotEqual, (fwObject)null);
      else
        return new fwExpression(a, fwOperator.opNotEqual, b.InnerDataObject);
    }
    public override bool Equals(object obj) { return InnerDataObject.Equals(obj); }
    public override int GetHashCode() { return InnerDataObject.GetHashCode(); }



    public static RequestsCollection All
    {
      get
      {
        RequestsCollection tmp = new RequestsCollection(false);
        return tmp;
      }
    }
	  public static RequestsCollection AllEx(fwExpression expression)
	  {
		  return new RequestsCollection(expression, true);
	  }

  	public static class Members
	  {
	
      private static fwMember m_RequestID = null;
      public static fwMember RequestID
      {
        get
        {
          fwThread.SecureInit<fwMember>(ref m_RequestID, delegate() { return Requests.Class.Members["RequestID"]; });
          return m_RequestID;
        }
      }
		
      private static fwMember m_InitialDescription = null;
      public static fwMember InitialDescription
      {
        get
        {
          fwThread.SecureInit<fwMember>(ref m_InitialDescription, delegate() { return Requests.Class.Members["InitialDescription"]; });
          return m_InitialDescription;
        }
      }
		
      private static fwMember m_RequestStatus = null;
      public static fwMember RequestStatus
      {
        get
        {
          fwThread.SecureInit<fwMember>(ref m_RequestStatus, delegate() { return Requests.Class.Members["RequestStatus"]; });
          return m_RequestStatus;
        }
      }
		
      private static fwMember m_DateSubmitted = null;
      public static fwMember DateSubmitted
      {
        get
        {
          fwThread.SecureInit<fwMember>(ref m_DateSubmitted, delegate() { return Requests.Class.Members["DateSubmitted"]; });
          return m_DateSubmitted;
        }
      }
		
      private static fwMember m_AttachmentFileName = null;
      public static fwMember AttachmentFileName
      {
        get
        {
          fwThread.SecureInit<fwMember>(ref m_AttachmentFileName, delegate() { return Requests.Class.Members["AttachmentFileName"]; });
          return m_AttachmentFileName;
        }
      }
		
      private static fwMember m_Users_User = null;
      public static fwMember Users_User
      {
        get
        {
          fwThread.SecureInit<fwMember>(ref m_Users_User, delegate() { return Requests.Class.Members["Users_User"]; });
          return m_Users_User;
        }
      }
		
      private static fwMember m_Categories_Category = null;
      public static fwMember Categories_Category
      {
        get
        {
          fwThread.SecureInit<fwMember>(ref m_Categories_Category, delegate() { return Requests.Class.Members["Categories_Category"]; });
          return m_Categories_Category;
        }
      }
		
      private static fwCollectionMember m_Eventses = null;
      public static fwCollectionMember Eventses
      {
        get
        {
          fwThread.SecureInit<fwCollectionMember>(ref m_Eventses, delegate() { return Requests.Class.CollectionMembers["Eventses"]; });
          return m_Eventses;
        }
      }
		
	  }



#endregion


#if !DEBUG
    [fwClass("Live", "Requests", "m_RequestID", null, IsDynamicData = true, DBGen = "PassionORM")]
    [DebuggerStepThrough()]
#else
    [fwClass("Development", "Requests", "m_RequestID", null, IsDynamicData = true, DBGen = "PassionORM")]
#endif
    [Serializable]
    public partial class data_Requests : fwObject<Requests, data_Requests, fwInt32>
    {

#region " ISerializable Members "

      protected data_Requests(SerializationInfo info, StreamingContext context)
      {
        base.DeSerialize(info, context);
      }

#endregion
#region Framework Key Access Routines

  	  // Rendered for Extra Speed
    
      public data_Requests() : base() { }
      internal data_Requests(Requests parent) : base()
      {
        DefaultParent = parent;
      }
    
      protected override fwType GetKeyValue()
      {
        return m_RequestID;
      }
      protected override fwInt32 GetKeyValueTyped()
      {

        return m_RequestID;
	
      }
      protected override void SetKeyValue(fwType value)
      {

        m_PersistenceState = fwObjectStatus.ExistingDirty;
        m_RequestID = value as fwInt32;
	
      }

	    protected override void SetValueAsRecordIndex(int MyRecordIndex, IDataRecord MyRecord)
      {
        if (MyRecord.IsDBNull(MyRecordIndex) == true)
        {
          m_PersistenceState = fwObjectStatus.New; 
          m_RequestID = null;
        }
        else
        {
          m_PersistenceState = fwObjectStatus.ExistingDirty; 
          m_RequestID = new fwInt32(MyRecord.GetInt32(MyRecordIndex));
        }
      }

      public static fwCollection All()
      {
        fwCollection tmp = ((fwInnerCollection)new RequestsCollection(false)).GetInnerCollection();
        return tmp;
      }

      public override Requests DefaultParent
      {
        get
        {
          if ((object)m_DefaultParent == null)
            m_DefaultParent = new Requests(this);
          return m_DefaultParent;
        }
        set
        {
          if ((object)m_DefaultParent == null)
            m_DefaultParent = value;
        }
      }
#endregion
		
		
#region "Member: RequestID"

	[fwMember("RequestID" 
		, Name = "RequestID"
		, Order = 1
		, IsHidden = true 
		, IsReadOnly = false
		, IsNullable = false
		, HasRemoteValue = false
		, IsUnique = true
		, CaseSensitive = true
		, Length = 4
		, HasTranslation = false
		)]
	
	public fwInt32 m_RequestID = null;
				
			
#endregion
			
#region "Member: InitialDescription"

	[fwMember("InitialDescription" 
		, Name = "InitialDescription"
		, Order = 2
		, IsHidden = false 
		, IsReadOnly = false
		, IsNullable = false
		, HasRemoteValue = false
		, IsUnique = false
		, CaseSensitive = false
		, Length = 1000
		, HasTranslation = false
		)]
	
	public fwString m_InitialDescription = null;
				
			
#endregion
			
#region "Member: RequestStatus"

	[fwMember("RequestStatus" 
		, Name = "RequestStatus"
		, Order = 3
		, IsHidden = false 
		, IsReadOnly = false
		, IsNullable = false
		, HasRemoteValue = false
		, IsUnique = false
		, CaseSensitive = false
		, Length = 50
		, HasTranslation = false
		)]
	
	public fwString m_RequestStatus = null;
				
			
#endregion
			
#region "Member: DateSubmitted"

	[fwMember("DateSubmitted" 
		, Name = "DateSubmitted"
		, Order = 4
		, IsHidden = false 
		, IsReadOnly = false
		, IsNullable = false
		, HasRemoteValue = false
		, IsUnique = false
		, CaseSensitive = true
		, Length = 8
		, HasTranslation = false
		)]
	
	public fwDateTime m_DateSubmitted = null;
				
			
#endregion
			
#region "Member: AttachmentFileName"

	[fwMember("AttachmentFileName" 
		, Name = "AttachmentFileName"
		, Order = 5
		, IsHidden = false 
		, IsReadOnly = false
		, IsNullable = true
		, HasRemoteValue = false
		, IsUnique = false
		, CaseSensitive = false
		, Length = 200
		, HasTranslation = false
		)]
	
	public fwString m_AttachmentFileName = null;
				
			
#endregion
			
#region "Member: Users_User"

	[fwMember("Users_UserID" 
		, Name = "Users_User"
		, Order = 6
		, IsHidden = false 
		, IsReadOnly = false
		, IsNullable = false
		, HasRemoteValue = false
		, IsUnique = false
		, CaseSensitive = true
		, Length = 4
		, HasTranslation = false
		)]
	
	public Users.data_Users m_Users_User = null;
			
#endregion
			
#region "Member: Categories_Category"

	[fwMember("Categories_CategoryID" 
		, Name = "Categories_Category"
		, Order = 7
		, IsHidden = false 
		, IsReadOnly = false
		, IsNullable = false
		, HasRemoteValue = false
		, IsUnique = false
		, CaseSensitive = true
		, Length = 4
		, HasTranslation = false
		)]
	
	public Categories.data_Categories m_Categories_Category = null;
			
#endregion
			
#region "Member: Eventses"

	[fwCollectionMember("Requests_RequestID"
		, Name = "Eventses"
		, Order = 8
		, IsHidden = false 
		, IsReadOnly = false
		, IsNullable = false
		, IsUnique = false
	)]
	
	public EventsCollection.data_EventsCollection m_Eventses = null;

#endregion
			

	  }
#region "Members"
		
#region "Member: RequestID"
/// <summary></summary>
    public fwInt32 RequestID
  	{
	  	get
		  {
  		  return InnerDataObject.m_RequestID;
		  }
		  set
		  {
          if (InnerDataObject.PersistenceState != fwObjectStatus.New && InnerDataObject.PersistenceState != fwObjectStatus.NewChanged)
            throw new fwFunctionalException("You can not change the object it's key");
      
          InnerDataObject.LoadIfDirty();
	  	  if (InnerDataObject.m_RequestID != value)
        {
			    InnerDataObject.PropertyChange();
          InnerDataObject.m_RequestID = value;
        }
		  }
	  }

#endregion
		
#region "Member: InitialDescription"
/// <summary></summary>
    public fwString InitialDescription
  	{
	  	get
		  {
  		  InnerDataObject.LoadIfDirty(); return InnerDataObject.m_InitialDescription;
		  }
		  set
		  {
          InnerDataObject.LoadIfDirty();
	  	  if (InnerDataObject.m_InitialDescription != value)
        {
			    InnerDataObject.PropertyChange();
          InnerDataObject.m_InitialDescription = value;
        }
		  }
	  }

#endregion
		
#region "Member: RequestStatus"
/// <summary></summary>
    public fwString RequestStatus
  	{
	  	get
		  {
  		  InnerDataObject.LoadIfDirty(); return InnerDataObject.m_RequestStatus;
		  }
		  set
		  {
          InnerDataObject.LoadIfDirty();
	  	  if (InnerDataObject.m_RequestStatus != value)
        {
			    InnerDataObject.PropertyChange();
          InnerDataObject.m_RequestStatus = value;
        }
		  }
	  }

#endregion
		
#region "Member: DateSubmitted"
/// <summary></summary>
    public fwDateTime DateSubmitted
  	{
	  	get
		  {
  		  InnerDataObject.LoadIfDirty(); return InnerDataObject.m_DateSubmitted;
		  }
		  set
		  {
          InnerDataObject.LoadIfDirty();
	  	  if (InnerDataObject.m_DateSubmitted != value)
        {
			    InnerDataObject.PropertyChange();
          InnerDataObject.m_DateSubmitted = value;
        }
		  }
	  }

#endregion
		
#region "Member: AttachmentFileName"
/// <summary></summary>
    public fwString AttachmentFileName
  	{
	  	get
		  {
  		  InnerDataObject.LoadIfDirty(); return InnerDataObject.m_AttachmentFileName;
		  }
		  set
		  {
          InnerDataObject.LoadIfDirty();
	  	  if (InnerDataObject.m_AttachmentFileName != value)
        {
			    InnerDataObject.PropertyChange();
          InnerDataObject.m_AttachmentFileName = value;
        }
		  }
	  }

#endregion
		
#region "Member: Users_User"
/// <summary></summary>        
    public Users Users_User
    {
      get
      {
        return LookupGet<Users, Users.data_Users>(this, Requests.Members.Users_User);
      }
      set
      {
        LookupSet<Requests, Requests.data_Requests, Users, RequestsCollection, RequestsCollection.data_RequestsCollection>(this.InnerDataObject, value, Requests.Members.Users_User, Users.Class.CollectionMembers["Requestses"], Requests.Members.RequestID, Requests.Members.Users_User);
      }
    }
			
#endregion
		
#region "Member: Categories_Category"
/// <summary></summary>        
    public Categories Categories_Category
    {
      get
      {
        return LookupGet<Categories, Categories.data_Categories>(this, Requests.Members.Categories_Category);
      }
      set
      {
        LookupSet<Requests, Requests.data_Requests, Categories, RequestsCollection, RequestsCollection.data_RequestsCollection>(this.InnerDataObject, value, Requests.Members.Categories_Category, Categories.Class.CollectionMembers["Requestses"], Requests.Members.RequestID, Requests.Members.Categories_Category);
      }
    }
			
#endregion
		
#region "Member: Eventses"
/// <summary></summary>
    public EventsCollection Eventses
    {
      get
      {
        InnerDataObject.LoadIfDirty();
        if ((object)InnerDataObject.m_Eventses == null)
          InnerDataObject.m_Eventses = InnerCollectionGet<EventsCollection, EventsCollection.data_EventsCollection, Events, Events.data_Events>(this, null, false, Requests.Members.RequestID, Events.Members.Requests_Request);
        return InnerDataObject.m_Eventses.DefaultParent;
      }
    }
/// <summary></summary>
    public EventsCollection EventsesEx()
    {
      return EventsesEx(null);
    }
    /// <summary></summary>
    public EventsCollection EventsesEx(fwExpression expression)
    {
      return CollectionGet<EventsCollection, Events>(this, expression, true, Requests.Members.RequestID, Events.Members.Requests_Request);
    }

    /// <summary></summary>
    public Events EventsEx(fwExpression expression)
    {
      if ((object)InnerDataObject.m_RequestID == null)
        return null;
      EventsCollection tmp = CollectionGet<EventsCollection, Events>(this, expression, true, Requests.Members.RequestID, Events.Members.Requests_Request);
      tmp.MaxLength = 1;
      if (tmp.Count == 0)
        return null;
      else
        return tmp[0];
    }
    /// <summary></summary>
    public Events EventsEx()
    {
      if ((object)InnerDataObject.m_RequestID == null) { return null; }
      return Events.TryLoad(new fwExpression(Events.Members.Requests_Request, fwOperator.opEqual, (fwType)InnerDataObject.m_RequestID));
    }

    public Events AddEvents()
    {
      InnerDataObject.LoadIfDirty(); Events lc = new Events(); lc.Requests_Request = this; return lc;
    }
    public void RemoveEvents(Events item)
    {
      using (fwTransaction trans = new fwTransaction()) { RemoveEvents(item, trans); trans.Commit(); }
    }
    public void RemoveEvents(Events item, fwTransaction trans)
    {
      InnerDataObject.LoadIfDirty();
      if ((object)((Events)item).Requests_Request != null && (Requests)((Events)item).Requests_Request == this)
        ((Events)item).Delete(trans); 
    }

#endregion
		
#endregion

#region "Interface Members"
    
#endregion

    
  }
#endregion
  
#region "Class: Users"

#if !DEBUG
[DebuggerStepThrough()]
#endif
[Serializable]
public partial class Users : fwProxy<Users, Users.data_Users, fwInt32>, fwInnerObject<Users.data_Users>
{

  #region " ISerializable Members "

  protected Users(SerializationInfo info, StreamingContext context)
  {
    base.DeSerialize(info, context);
  }

  #endregion
  #region Class Comparison and Default Translation

	static Users()
	{
		fwFactory.Initialise();
		
	}
    
	// Rendered for Extra Comfort
	public Users() : base() { }
	[Obsolete("Please use: new Users();", true)]
	public Users(bool initialize) : base(initialize) { }

	public Users(fwInt32 UserID) : base(UserID) { }
	public Users(int UserID) : base((fwInt32)UserID) { }
  
	public Users(fwString Name) : base(Name) { }
	public Users(string Name) : base((fwString)Name) { }

    public Users(fwExpression expression) : base(expression) { }
    internal Users(data_Users data) : base(data) { }


    new public static Users TryLoad(fwInt32 UserID)
    {
      return fwProxy<Users, Users.data_Users, fwInt32>.TryLoad(UserID);
    }
    public static Users TryLoad(int UserID)
    {
      return fwProxy<Users, Users.data_Users, fwInt32>.TryLoad((fwInt32)UserID);
    }

    new public static Users TryLoad(fwString Name)
    {
      return fwProxy<Users, Users.data_Users, fwInt32>.TryLoad(Name);
    }
    public static Users TryLoad(string Name)
    {
      return fwProxy<Users, Users.data_Users, fwInt32>.TryLoad((fwString)Name);
    }


    new public static Users TryLoad(fwExpression expression)
    {
      return fwProxy<Users, Users.data_Users, fwInt32>.TryLoad(expression);
    }

    public static bool operator ==(Users a, Users b)
    {
      if (((object)a == null) && ((object)b == null)) { return true; }
      if ((object)a == null)
        return b.InnerDataObject.Equals(a);
      else
        return a.InnerDataObject.Equals(b);
    }
	  public static bool operator !=(Users a, Users b)
    {
		  if (((object)a == null) && ((object)b == null)) { return false; }
		  if ((object)a == null)
  			return !b.InnerDataObject.Equals(a);
		  else
  			return !a.InnerDataObject.Equals(b);
    }
  	public static fwExpression operator ==(fwMember a, Users b)
    {
  	  if ((object)b == null)
        return new fwExpression(a, fwOperator.opEqual, (fwObject)null);
      else
        return new fwExpression(a, fwOperator.opEqual, b.InnerDataObject);
    }
  	public static fwExpression operator !=(fwMember a, Users b)
    {
  	  if ((object)b == null)
        return new fwExpression(a, fwOperator.opNotEqual, (fwObject)null);
      else
        return new fwExpression(a, fwOperator.opNotEqual, b.InnerDataObject);
    }
    public override bool Equals(object obj) { return InnerDataObject.Equals(obj); }
    public override int GetHashCode() { return InnerDataObject.GetHashCode(); }



    public static UsersCollection All
    {
      get
      {
        UsersCollection tmp = new UsersCollection(false);
        return tmp;
      }
    }
	  public static UsersCollection AllEx(fwExpression expression)
	  {
		  return new UsersCollection(expression, true);
	  }

  	public static class Members
	  {
	
      private static fwMember m_UserID = null;
      public static fwMember UserID
      {
        get
        {
          fwThread.SecureInit<fwMember>(ref m_UserID, delegate() { return Users.Class.Members["UserID"]; });
          return m_UserID;
        }
      }
		
      private static fwMember m_Username = null;
      public static fwMember Username
      {
        get
        {
          fwThread.SecureInit<fwMember>(ref m_Username, delegate() { return Users.Class.Members["Username"]; });
          return m_Username;
        }
      }
		
      private static fwMember m_Password = null;
      public static fwMember Password
      {
        get
        {
          fwThread.SecureInit<fwMember>(ref m_Password, delegate() { return Users.Class.Members["Password"]; });
          return m_Password;
        }
      }
		
      private static fwMember m_Name = null;
      public static fwMember Name
      {
        get
        {
          fwThread.SecureInit<fwMember>(ref m_Name, delegate() { return Users.Class.Members["Name"]; });
          return m_Name;
        }
      }
		
      private static fwMember m_Email = null;
      public static fwMember Email
      {
        get
        {
          fwThread.SecureInit<fwMember>(ref m_Email, delegate() { return Users.Class.Members["Email"]; });
          return m_Email;
        }
      }
		
      private static fwMember m_Phone = null;
      public static fwMember Phone
      {
        get
        {
          fwThread.SecureInit<fwMember>(ref m_Phone, delegate() { return Users.Class.Members["Phone"]; });
          return m_Phone;
        }
      }
		
      private static fwMember m_Company = null;
      public static fwMember Company
      {
        get
        {
          fwThread.SecureInit<fwMember>(ref m_Company, delegate() { return Users.Class.Members["Company"]; });
          return m_Company;
        }
      }
		
      private static fwMember m_UserType = null;
      public static fwMember UserType
      {
        get
        {
          fwThread.SecureInit<fwMember>(ref m_UserType, delegate() { return Users.Class.Members["UserType"]; });
          return m_UserType;
        }
      }
		
      private static fwCollectionMember m_Requestses = null;
      public static fwCollectionMember Requestses
      {
        get
        {
          fwThread.SecureInit<fwCollectionMember>(ref m_Requestses, delegate() { return Users.Class.CollectionMembers["Requestses"]; });
          return m_Requestses;
        }
      }
		
	  }



#endregion


#if !DEBUG
    [fwClass("Live", "Users", "m_UserID", "m_Name", IsDynamicData = true, DBGen = "PassionORM")]
    [DebuggerStepThrough()]
#else
    [fwClass("Development", "Users", "m_UserID", "m_Name", IsDynamicData = true, DBGen = "PassionORM")]
#endif
    [Serializable]
    public partial class data_Users : fwObject<Users, data_Users, fwInt32>
    {

#region " ISerializable Members "

      protected data_Users(SerializationInfo info, StreamingContext context)
      {
        base.DeSerialize(info, context);
      }

#endregion
#region Framework Key Access Routines

  	  // Rendered for Extra Speed
    
      public data_Users() : base() { }
      internal data_Users(Users parent) : base()
      {
        DefaultParent = parent;
      }
    
      protected override fwType GetKeyValue()
      {
        return m_UserID;
      }
      protected override fwInt32 GetKeyValueTyped()
      {

        return m_UserID;
	
      }
      protected override void SetKeyValue(fwType value)
      {

        m_PersistenceState = fwObjectStatus.ExistingDirty;
        m_UserID = value as fwInt32;
	
      }

	    protected override void SetValueAsRecordIndex(int MyRecordIndex, IDataRecord MyRecord)
      {
        if (MyRecord.IsDBNull(MyRecordIndex) == true)
        {
          m_PersistenceState = fwObjectStatus.New; 
          m_UserID = null;
        }
        else
        {
          m_PersistenceState = fwObjectStatus.ExistingDirty; 
          m_UserID = new fwInt32(MyRecord.GetInt32(MyRecordIndex));
        }
      }

      public static fwCollection All()
      {
        fwCollection tmp = ((fwInnerCollection)new UsersCollection(false)).GetInnerCollection();
        return tmp;
      }

      public override Users DefaultParent
      {
        get
        {
          if ((object)m_DefaultParent == null)
            m_DefaultParent = new Users(this);
          return m_DefaultParent;
        }
        set
        {
          if ((object)m_DefaultParent == null)
            m_DefaultParent = value;
        }
      }
#endregion
		
		
#region "Member: UserID"

	[fwMember("UserID" 
		, Name = "UserID"
		, Order = 1
		, IsHidden = true 
		, IsReadOnly = false
		, IsNullable = false
		, HasRemoteValue = false
		, IsUnique = true
		, CaseSensitive = true
		, Length = 4
		, HasTranslation = false
		)]
	
	public fwInt32 m_UserID = null;
				
			
#endregion
			
#region "Member: Username"

	[fwMember("Username" 
		, Name = "Username"
		, Order = 2
		, IsHidden = false 
		, IsReadOnly = false
		, IsNullable = false
		, HasRemoteValue = false
		, IsUnique = false
		, CaseSensitive = false
		, Length = 50
		, HasTranslation = false
		)]
	
	public fwString m_Username = null;
				
			
#endregion
			
#region "Member: Password"

	[fwMember("Password" 
		, Name = "Password"
		, Order = 3
		, IsHidden = false 
		, IsReadOnly = false
		, IsNullable = false
		, HasRemoteValue = false
		, IsUnique = false
		, CaseSensitive = false
		, Length = 50
		, HasTranslation = false
		)]
	
	public fwString m_Password = null;
				
			
#endregion
			
#region "Member: Name"

	[fwMember("Name" 
		, Name = "Name"
		, Order = 4
		, IsHidden = false 
		, IsReadOnly = false
		, IsNullable = false
		, HasRemoteValue = false
		, IsUnique = false
		, CaseSensitive = false
		, Length = 50
		, HasTranslation = false
		)]
	
	public fwString m_Name = null;
				
			
#endregion
			
#region "Member: Email"

	[fwMember("Email" 
		, Name = "Email"
		, Order = 5
		, IsHidden = false 
		, IsReadOnly = false
		, IsNullable = false
		, HasRemoteValue = false
		, IsUnique = false
		, CaseSensitive = false
		, Length = 50
		, HasTranslation = false
		)]
	
	public fwString m_Email = null;
				
			
#endregion
			
#region "Member: Phone"

	[fwMember("Phone" 
		, Name = "Phone"
		, Order = 6
		, IsHidden = false 
		, IsReadOnly = false
		, IsNullable = false
		, HasRemoteValue = false
		, IsUnique = false
		, CaseSensitive = true
		, Length = 4
		, HasTranslation = false
		)]
	
	public fwInt32 m_Phone = null;
				
			
#endregion
			
#region "Member: Company"

	[fwMember("Company" 
		, Name = "Company"
		, Order = 7
		, IsHidden = false 
		, IsReadOnly = false
		, IsNullable = false
		, HasRemoteValue = false
		, IsUnique = false
		, CaseSensitive = false
		, Length = 50
		, HasTranslation = false
		)]
	
	public fwString m_Company = null;
				
			
#endregion
			
#region "Member: UserType"

	[fwMember("UserType" 
		, Name = "UserType"
		, Order = 8
		, IsHidden = false 
		, IsReadOnly = false
		, IsNullable = false
		, HasRemoteValue = false
		, IsUnique = false
		, CaseSensitive = false
		, Length = 50
		, HasTranslation = false
		)]
	
	public fwString m_UserType = null;
				
			
#endregion
			
#region "Member: Requestses"

	[fwCollectionMember("Users_UserID"
		, Name = "Requestses"
		, Order = 9
		, IsHidden = false 
		, IsReadOnly = false
		, IsNullable = false
		, IsUnique = false
	)]
	
	public RequestsCollection.data_RequestsCollection m_Requestses = null;

#endregion
			

	  }
#region "Members"
		
#region "Member: UserID"
/// <summary></summary>
    public fwInt32 UserID
  	{
	  	get
		  {
  		  return InnerDataObject.m_UserID;
		  }
		  set
		  {
          if (InnerDataObject.PersistenceState != fwObjectStatus.New && InnerDataObject.PersistenceState != fwObjectStatus.NewChanged)
            throw new fwFunctionalException("You can not change the object it's key");
      
          InnerDataObject.LoadIfDirty();
	  	  if (InnerDataObject.m_UserID != value)
        {
			    InnerDataObject.PropertyChange();
          InnerDataObject.m_UserID = value;
        }
		  }
	  }

#endregion
		
#region "Member: Username"
/// <summary></summary>
    public fwString Username
  	{
	  	get
		  {
  		  InnerDataObject.LoadIfDirty(); return InnerDataObject.m_Username;
		  }
		  set
		  {
          InnerDataObject.LoadIfDirty();
	  	  if (InnerDataObject.m_Username != value)
        {
			    InnerDataObject.PropertyChange();
          InnerDataObject.m_Username = value;
        }
		  }
	  }

#endregion
		
#region "Member: Password"
/// <summary></summary>
    public fwString Password
  	{
	  	get
		  {
  		  InnerDataObject.LoadIfDirty(); return InnerDataObject.m_Password;
		  }
		  set
		  {
          InnerDataObject.LoadIfDirty();
	  	  if (InnerDataObject.m_Password != value)
        {
			    InnerDataObject.PropertyChange();
          InnerDataObject.m_Password = value;
        }
		  }
	  }

#endregion
		
#region "Member: Name"
/// <summary></summary>
    public fwString Name
  	{
	  	get
		  {
  		  InnerDataObject.LoadIfDirty(); return InnerDataObject.m_Name;
		  }
		  set
		  {
          InnerDataObject.LoadIfDirty();
	  	  if (InnerDataObject.m_Name != value)
        {
			    InnerDataObject.PropertyChange();
          InnerDataObject.m_Name = value;
        }
		  }
	  }

#endregion
		
#region "Member: Email"
/// <summary></summary>
    public fwString Email
  	{
	  	get
		  {
  		  InnerDataObject.LoadIfDirty(); return InnerDataObject.m_Email;
		  }
		  set
		  {
          InnerDataObject.LoadIfDirty();
	  	  if (InnerDataObject.m_Email != value)
        {
			    InnerDataObject.PropertyChange();
          InnerDataObject.m_Email = value;
        }
		  }
	  }

#endregion
		
#region "Member: Phone"
/// <summary></summary>
    public fwInt32 Phone
  	{
	  	get
		  {
  		  InnerDataObject.LoadIfDirty(); return InnerDataObject.m_Phone;
		  }
		  set
		  {
          InnerDataObject.LoadIfDirty();
	  	  if (InnerDataObject.m_Phone != value)
        {
			    InnerDataObject.PropertyChange();
          InnerDataObject.m_Phone = value;
        }
		  }
	  }

#endregion
		
#region "Member: Company"
/// <summary></summary>
    public fwString Company
  	{
	  	get
		  {
  		  InnerDataObject.LoadIfDirty(); return InnerDataObject.m_Company;
		  }
		  set
		  {
          InnerDataObject.LoadIfDirty();
	  	  if (InnerDataObject.m_Company != value)
        {
			    InnerDataObject.PropertyChange();
          InnerDataObject.m_Company = value;
        }
		  }
	  }

#endregion
		
#region "Member: UserType"
/// <summary></summary>
    public fwString UserType
  	{
	  	get
		  {
  		  InnerDataObject.LoadIfDirty(); return InnerDataObject.m_UserType;
		  }
		  set
		  {
          InnerDataObject.LoadIfDirty();
	  	  if (InnerDataObject.m_UserType != value)
        {
			    InnerDataObject.PropertyChange();
          InnerDataObject.m_UserType = value;
        }
		  }
	  }

#endregion
		
#region "Member: Requestses"
/// <summary></summary>
    public RequestsCollection Requestses
    {
      get
      {
        InnerDataObject.LoadIfDirty();
        if ((object)InnerDataObject.m_Requestses == null)
          InnerDataObject.m_Requestses = InnerCollectionGet<RequestsCollection, RequestsCollection.data_RequestsCollection, Requests, Requests.data_Requests>(this, null, false, Users.Members.UserID, Requests.Members.Users_User);
        return InnerDataObject.m_Requestses.DefaultParent;
      }
    }
/// <summary></summary>
    public RequestsCollection RequestsesEx()
    {
      return RequestsesEx(null);
    }
    /// <summary></summary>
    public RequestsCollection RequestsesEx(fwExpression expression)
    {
      return CollectionGet<RequestsCollection, Requests>(this, expression, true, Users.Members.UserID, Requests.Members.Users_User);
    }

    /// <summary></summary>
    public Requests RequestsEx(fwExpression expression)
    {
      if ((object)InnerDataObject.m_UserID == null)
        return null;
      RequestsCollection tmp = CollectionGet<RequestsCollection, Requests>(this, expression, true, Users.Members.UserID, Requests.Members.Users_User);
      tmp.MaxLength = 1;
      if (tmp.Count == 0)
        return null;
      else
        return tmp[0];
    }
    /// <summary></summary>
    public Requests RequestsEx()
    {
      if ((object)InnerDataObject.m_UserID == null) { return null; }
      return Requests.TryLoad(new fwExpression(Requests.Members.Users_User, fwOperator.opEqual, (fwType)InnerDataObject.m_UserID));
    }

    public Requests AddRequests()
    {
      InnerDataObject.LoadIfDirty(); Requests lc = new Requests(); lc.Users_User = this; return lc;
    }
    public void RemoveRequests(Requests item)
    {
      using (fwTransaction trans = new fwTransaction()) { RemoveRequests(item, trans); trans.Commit(); }
    }
    public void RemoveRequests(Requests item, fwTransaction trans)
    {
      InnerDataObject.LoadIfDirty();
      if ((object)((Requests)item).Users_User != null && (Users)((Requests)item).Users_User == this)
        ((Requests)item).Delete(trans); 
    }

#endregion
		
#endregion

#region "Interface Members"
    
#endregion

    
  }
#endregion
  
}
