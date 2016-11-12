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
  
#region "Collection: Categories"

#if !DEBUG
  [DebuggerStepThrough()]
#endif
  [Serializable]
  public partial class CategoriesCollection : fwProxyCollection<CategoriesCollection, CategoriesCollection.data_CategoriesCollection, Categories, Categories.data_Categories>
  {

#region "Constructors"

	  static CategoriesCollection()
	  {
  		fwFactory.Initialise();
  	}

    [Obsolete("Please use: new CategoriesCollection(false);", true)]
    public CategoriesCollection() : base(false) {}
    public CategoriesCollection(bool blank) : base(blank) {}
    internal CategoriesCollection(bool blank, bool disconnected) : base(blank, disconnected) {}
    public CategoriesCollection(fwExpression expression) : base(expression) {}
    internal CategoriesCollection(fwExpression expression, bool disconnected) : base(expression, disconnected) {}
    public CategoriesCollection(data_CategoriesCollection innercollection) : base(innercollection) {}
    protected CategoriesCollection(SerializationInfo info, StreamingContext context) : base((data_CategoriesCollection)null)
    {
      base.DeSerialize(info, context);
    }

#endregion

#region "Interface Specific"


#endregion

#region "Members"
		
#region "Member: Requests"
    public CategoriesCollection IncludeRequestsEx(RequestsCollection collection)
    {
      return Include<CategoriesCollection, RequestsCollection>(this, collection, this.Members.CategoryID, collection.Members.Categories_Category);
    }
    public CategoriesCollection IncludeRequestsEx(fwExpression expression)
    {
      return IncludeRequestsEx(new RequestsCollection(expression));
    }
    public CategoriesCollection IncludeRequests
    {
      get { return IncludeRequestsEx(new RequestsCollection((fwExpression)null)); }
    }
    public CategoriesCollection ExcludeRequestsEx(RequestsCollection collection)
    {
      return Exclude<CategoriesCollection, RequestsCollection>(this, collection, this.Members.CategoryID, collection.Members.Categories_Category);
    }
    public CategoriesCollection ExcludeRequestsEx(fwExpression expression)
    {
      return ExcludeRequestsEx(new RequestsCollection(expression));
    }
    public CategoriesCollection ExcludeRequests
    {
      get { return ExcludeRequestsEx(new RequestsCollection((fwExpression)null)); }
    }
    public RequestsCollection JumpToRequests
    {
      get
      {
        return JumpToRequestsEx(null);
      }
    }
    public RequestsCollection JumpToRequestsEx(fwExpression expression)
    {
      RequestsCollection collection = new RequestsCollection(expression, true);
      return JumpTo<CategoriesCollection, RequestsCollection>(this, collection, this.Members.CategoryID, collection.Members.Categories_Category);
    }
#endregion
				
#endregion

#region "Enumerators"

    public IEnumerable<Categories> Reverse { get { Refresh(); return new ReversedHandler(InnerDataCollection.Reverse); } }
    public struct ReversedHandler : IEnumerable<Categories>, System.Collections.IEnumerable
    {
      internal ReversedHandler(IEnumerator<Categories.data_Categories> innerenum) { innerenumerator = innerenum; }
      
      IEnumerator<Categories.data_Categories> innerenumerator;

      System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return new ReversedEnumerator(innerenumerator); }

      public IEnumerator<Categories> GetEnumerator() { return new ReversedEnumerator(innerenumerator); }
    }

#endregion

#region "InnerData"

#if !DEBUG
    [DebuggerStepThrough()]
#endif
    [fwCollection(typeof(Categories.data_Categories))]
    public class data_CategoriesCollection : fwCollection<CategoriesCollection ,Categories.data_Categories> 
    {
      [Obsolete("Please use: new data_CategoriesCollection(false);", true)]
      public data_CategoriesCollection() : base(true) { }
      internal data_CategoriesCollection(bool disconnected) : base(disconnected) { }
      internal data_CategoriesCollection(fwExpression expression, bool disconnected) : base(expression, disconnected) { }
    }

#endregion

#region "fwClass & fwMember Shortcuts"

    protected AliasMembers m_aliasmembers = null;
    public AliasMembers Members
    {
      get
      {
        if ((object)m_aliasmembers == null) m_aliasmembers = new AliasMembers(InnerDataCollection.Class);
        return m_aliasmembers;
      }
    }
    public class AliasMembers
    {

      internal AliasMembers(fwAlias alias)
      {
        m_Alias = alias;
      }
      fwAlias m_Alias = null;
    
      private fwMember m_CategoryID = null;
      public fwMember CategoryID
      {
        get
        {
          if ((object)m_CategoryID == null)
            m_CategoryID = m_Alias.Members["CategoryID"];

          return m_CategoryID;
        }
      }

      private fwMember m_CategoryName = null;
      public fwMember CategoryName
      {
        get
        {
          if ((object)m_CategoryName == null)
            m_CategoryName = m_Alias.Members["CategoryName"];

          return m_CategoryName;
        }
      }

      private fwMember m_CategoryDescriptoin = null;
      public fwMember CategoryDescriptoin
      {
        get
        {
          if ((object)m_CategoryDescriptoin == null)
            m_CategoryDescriptoin = m_Alias.Members["CategoryDescriptoin"];

          return m_CategoryDescriptoin;
        }
      }

      private fwCollectionMember m_Requestses = null;
      public fwCollectionMember Requestses
      {
        get
        {
          if ((object)m_Requestses == null)
            m_Requestses = m_Alias.CollectionMembers["Requestses"];

          return m_Requestses;
        }
      }

    }
    
#endregion    
  }

#endregion

#region "Collection: Events"

#if !DEBUG
  [DebuggerStepThrough()]
#endif
  [Serializable]
  public partial class EventsCollection : fwProxyCollection<EventsCollection, EventsCollection.data_EventsCollection, Events, Events.data_Events>
  {

#region "Constructors"

	  static EventsCollection()
	  {
  		fwFactory.Initialise();
  	}

    [Obsolete("Please use: new EventsCollection(false);", true)]
    public EventsCollection() : base(false) {}
    public EventsCollection(bool blank) : base(blank) {}
    internal EventsCollection(bool blank, bool disconnected) : base(blank, disconnected) {}
    public EventsCollection(fwExpression expression) : base(expression) {}
    internal EventsCollection(fwExpression expression, bool disconnected) : base(expression, disconnected) {}
    public EventsCollection(data_EventsCollection innercollection) : base(innercollection) {}
    protected EventsCollection(SerializationInfo info, StreamingContext context) : base((data_EventsCollection)null)
    {
      base.DeSerialize(info, context);
    }

#endregion

#region "Interface Specific"


#endregion

#region "Members"
		
#region "Member: Requests_Request"
    public EventsCollection IncludeRequests_RequestEx(RequestsCollection collection)
    {
      return Include<EventsCollection, RequestsCollection>(this, collection, this.Members.Requests_Request, collection.Members.RequestID);
    }
    public EventsCollection IncludeRequests_RequestEx(fwExpression expression)
    {
      return IncludeRequests_RequestEx(new RequestsCollection(expression));
    }
    public EventsCollection IncludeRequests_Request
    {
      get { return IncludeRequests_RequestEx(new RequestsCollection((fwExpression)null)); }
    }
    public EventsCollection ExcludeRequests_RequestEx(RequestsCollection collection)
    {
      return Exclude<EventsCollection, RequestsCollection>(this, collection, this.Members.Requests_Request, collection.Members.RequestID);
    }
    public EventsCollection ExcludeRequests_RequestEx(fwExpression expression)
    {
      return ExcludeRequests_RequestEx(new RequestsCollection(expression));
    }
    public EventsCollection ExcludeRequests_Request
    {
      get { return ExcludeRequests_RequestEx(new RequestsCollection((fwExpression)null)); }
    }
    public RequestsCollection JumpToRequests_Request
    {
      get
      {
        return JumpToRequests_RequestEx(null);
      }
    }
    public RequestsCollection JumpToRequests_RequestEx(fwExpression expression)
    {
      RequestsCollection collection = new RequestsCollection(expression, true);
      return JumpTo<EventsCollection, RequestsCollection>(this, collection, this.Members.Requests_Request, collection.Members.RequestID);
    }
#endregion
				
#endregion

#region "Enumerators"

    public IEnumerable<Events> Reverse { get { Refresh(); return new ReversedHandler(InnerDataCollection.Reverse); } }
    public struct ReversedHandler : IEnumerable<Events>, System.Collections.IEnumerable
    {
      internal ReversedHandler(IEnumerator<Events.data_Events> innerenum) { innerenumerator = innerenum; }
      
      IEnumerator<Events.data_Events> innerenumerator;

      System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return new ReversedEnumerator(innerenumerator); }

      public IEnumerator<Events> GetEnumerator() { return new ReversedEnumerator(innerenumerator); }
    }

#endregion

#region "InnerData"

#if !DEBUG
    [DebuggerStepThrough()]
#endif
    [fwCollection(typeof(Events.data_Events))]
    public class data_EventsCollection : fwCollection<EventsCollection ,Events.data_Events> 
    {
      [Obsolete("Please use: new data_EventsCollection(false);", true)]
      public data_EventsCollection() : base(true) { }
      internal data_EventsCollection(bool disconnected) : base(disconnected) { }
      internal data_EventsCollection(fwExpression expression, bool disconnected) : base(expression, disconnected) { }
    }

#endregion

#region "fwClass & fwMember Shortcuts"

    protected AliasMembers m_aliasmembers = null;
    public AliasMembers Members
    {
      get
      {
        if ((object)m_aliasmembers == null) m_aliasmembers = new AliasMembers(InnerDataCollection.Class);
        return m_aliasmembers;
      }
    }
    public class AliasMembers
    {

      internal AliasMembers(fwAlias alias)
      {
        m_Alias = alias;
      }
      fwAlias m_Alias = null;
    
      private fwMember m_EventID = null;
      public fwMember EventID
      {
        get
        {
          if ((object)m_EventID == null)
            m_EventID = m_Alias.Members["EventID"];

          return m_EventID;
        }
      }

      private fwMember m_EventDate = null;
      public fwMember EventDate
      {
        get
        {
          if ((object)m_EventDate == null)
            m_EventDate = m_Alias.Members["EventDate"];

          return m_EventDate;
        }
      }

      private fwMember m_RequestStatusChange = null;
      public fwMember RequestStatusChange
      {
        get
        {
          if ((object)m_RequestStatusChange == null)
            m_RequestStatusChange = m_Alias.Members["RequestStatusChange"];

          return m_RequestStatusChange;
        }
      }

      private fwMember m_RequestDescription = null;
      public fwMember RequestDescription
      {
        get
        {
          if ((object)m_RequestDescription == null)
            m_RequestDescription = m_Alias.Members["RequestDescription"];

          return m_RequestDescription;
        }
      }

      private fwMember m_EventDescription = null;
      public fwMember EventDescription
      {
        get
        {
          if ((object)m_EventDescription == null)
            m_EventDescription = m_Alias.Members["EventDescription"];

          return m_EventDescription;
        }
      }

      private fwMember m_Requests_Request = null;
      public fwMember Requests_Request
      {
        get
        {
          if ((object)m_Requests_Request == null)
            m_Requests_Request = m_Alias.Members["Requests_Request"];

          return m_Requests_Request;
        }
      }

    }
    
#endregion    
  }

#endregion

#region "Collection: Requests"

#if !DEBUG
  [DebuggerStepThrough()]
#endif
  [Serializable]
  public partial class RequestsCollection : fwProxyCollection<RequestsCollection, RequestsCollection.data_RequestsCollection, Requests, Requests.data_Requests>
  {

#region "Constructors"

	  static RequestsCollection()
	  {
  		fwFactory.Initialise();
  	}

    [Obsolete("Please use: new RequestsCollection(false);", true)]
    public RequestsCollection() : base(false) {}
    public RequestsCollection(bool blank) : base(blank) {}
    internal RequestsCollection(bool blank, bool disconnected) : base(blank, disconnected) {}
    public RequestsCollection(fwExpression expression) : base(expression) {}
    internal RequestsCollection(fwExpression expression, bool disconnected) : base(expression, disconnected) {}
    public RequestsCollection(data_RequestsCollection innercollection) : base(innercollection) {}
    protected RequestsCollection(SerializationInfo info, StreamingContext context) : base((data_RequestsCollection)null)
    {
      base.DeSerialize(info, context);
    }

#endregion

#region "Interface Specific"


#endregion

#region "Members"
		
#region "Member: Users_User"
    public RequestsCollection IncludeUsers_UserEx(UsersCollection collection)
    {
      return Include<RequestsCollection, UsersCollection>(this, collection, this.Members.Users_User, collection.Members.UserID);
    }
    public RequestsCollection IncludeUsers_UserEx(fwExpression expression)
    {
      return IncludeUsers_UserEx(new UsersCollection(expression));
    }
    public RequestsCollection IncludeUsers_User
    {
      get { return IncludeUsers_UserEx(new UsersCollection((fwExpression)null)); }
    }
    public RequestsCollection ExcludeUsers_UserEx(UsersCollection collection)
    {
      return Exclude<RequestsCollection, UsersCollection>(this, collection, this.Members.Users_User, collection.Members.UserID);
    }
    public RequestsCollection ExcludeUsers_UserEx(fwExpression expression)
    {
      return ExcludeUsers_UserEx(new UsersCollection(expression));
    }
    public RequestsCollection ExcludeUsers_User
    {
      get { return ExcludeUsers_UserEx(new UsersCollection((fwExpression)null)); }
    }
    public UsersCollection JumpToUsers_User
    {
      get
      {
        return JumpToUsers_UserEx(null);
      }
    }
    public UsersCollection JumpToUsers_UserEx(fwExpression expression)
    {
      UsersCollection collection = new UsersCollection(expression, true);
      return JumpTo<RequestsCollection, UsersCollection>(this, collection, this.Members.Users_User, collection.Members.UserID);
    }
#endregion
				
#region "Member: Categories_Category"
    public RequestsCollection IncludeCategories_CategoryEx(CategoriesCollection collection)
    {
      return Include<RequestsCollection, CategoriesCollection>(this, collection, this.Members.Categories_Category, collection.Members.CategoryID);
    }
    public RequestsCollection IncludeCategories_CategoryEx(fwExpression expression)
    {
      return IncludeCategories_CategoryEx(new CategoriesCollection(expression));
    }
    public RequestsCollection IncludeCategories_Category
    {
      get { return IncludeCategories_CategoryEx(new CategoriesCollection((fwExpression)null)); }
    }
    public RequestsCollection ExcludeCategories_CategoryEx(CategoriesCollection collection)
    {
      return Exclude<RequestsCollection, CategoriesCollection>(this, collection, this.Members.Categories_Category, collection.Members.CategoryID);
    }
    public RequestsCollection ExcludeCategories_CategoryEx(fwExpression expression)
    {
      return ExcludeCategories_CategoryEx(new CategoriesCollection(expression));
    }
    public RequestsCollection ExcludeCategories_Category
    {
      get { return ExcludeCategories_CategoryEx(new CategoriesCollection((fwExpression)null)); }
    }
    public CategoriesCollection JumpToCategories_Category
    {
      get
      {
        return JumpToCategories_CategoryEx(null);
      }
    }
    public CategoriesCollection JumpToCategories_CategoryEx(fwExpression expression)
    {
      CategoriesCollection collection = new CategoriesCollection(expression, true);
      return JumpTo<RequestsCollection, CategoriesCollection>(this, collection, this.Members.Categories_Category, collection.Members.CategoryID);
    }
#endregion
				
#region "Member: Events"
    public RequestsCollection IncludeEventsEx(EventsCollection collection)
    {
      return Include<RequestsCollection, EventsCollection>(this, collection, this.Members.RequestID, collection.Members.Requests_Request);
    }
    public RequestsCollection IncludeEventsEx(fwExpression expression)
    {
      return IncludeEventsEx(new EventsCollection(expression));
    }
    public RequestsCollection IncludeEvents
    {
      get { return IncludeEventsEx(new EventsCollection((fwExpression)null)); }
    }
    public RequestsCollection ExcludeEventsEx(EventsCollection collection)
    {
      return Exclude<RequestsCollection, EventsCollection>(this, collection, this.Members.RequestID, collection.Members.Requests_Request);
    }
    public RequestsCollection ExcludeEventsEx(fwExpression expression)
    {
      return ExcludeEventsEx(new EventsCollection(expression));
    }
    public RequestsCollection ExcludeEvents
    {
      get { return ExcludeEventsEx(new EventsCollection((fwExpression)null)); }
    }
    public EventsCollection JumpToEvents
    {
      get
      {
        return JumpToEventsEx(null);
      }
    }
    public EventsCollection JumpToEventsEx(fwExpression expression)
    {
      EventsCollection collection = new EventsCollection(expression, true);
      return JumpTo<RequestsCollection, EventsCollection>(this, collection, this.Members.RequestID, collection.Members.Requests_Request);
    }
#endregion
				
#endregion

#region "Enumerators"

    public IEnumerable<Requests> Reverse { get { Refresh(); return new ReversedHandler(InnerDataCollection.Reverse); } }
    public struct ReversedHandler : IEnumerable<Requests>, System.Collections.IEnumerable
    {
      internal ReversedHandler(IEnumerator<Requests.data_Requests> innerenum) { innerenumerator = innerenum; }
      
      IEnumerator<Requests.data_Requests> innerenumerator;

      System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return new ReversedEnumerator(innerenumerator); }

      public IEnumerator<Requests> GetEnumerator() { return new ReversedEnumerator(innerenumerator); }
    }

#endregion

#region "InnerData"

#if !DEBUG
    [DebuggerStepThrough()]
#endif
    [fwCollection(typeof(Requests.data_Requests))]
    public class data_RequestsCollection : fwCollection<RequestsCollection ,Requests.data_Requests> 
    {
      [Obsolete("Please use: new data_RequestsCollection(false);", true)]
      public data_RequestsCollection() : base(true) { }
      internal data_RequestsCollection(bool disconnected) : base(disconnected) { }
      internal data_RequestsCollection(fwExpression expression, bool disconnected) : base(expression, disconnected) { }
    }

#endregion

#region "fwClass & fwMember Shortcuts"

    protected AliasMembers m_aliasmembers = null;
    public AliasMembers Members
    {
      get
      {
        if ((object)m_aliasmembers == null) m_aliasmembers = new AliasMembers(InnerDataCollection.Class);
        return m_aliasmembers;
      }
    }
    public class AliasMembers
    {

      internal AliasMembers(fwAlias alias)
      {
        m_Alias = alias;
      }
      fwAlias m_Alias = null;
    
      private fwMember m_RequestID = null;
      public fwMember RequestID
      {
        get
        {
          if ((object)m_RequestID == null)
            m_RequestID = m_Alias.Members["RequestID"];

          return m_RequestID;
        }
      }

      private fwMember m_InitialDescription = null;
      public fwMember InitialDescription
      {
        get
        {
          if ((object)m_InitialDescription == null)
            m_InitialDescription = m_Alias.Members["InitialDescription"];

          return m_InitialDescription;
        }
      }

      private fwMember m_RequestStatus = null;
      public fwMember RequestStatus
      {
        get
        {
          if ((object)m_RequestStatus == null)
            m_RequestStatus = m_Alias.Members["RequestStatus"];

          return m_RequestStatus;
        }
      }

      private fwMember m_DateSubmitted = null;
      public fwMember DateSubmitted
      {
        get
        {
          if ((object)m_DateSubmitted == null)
            m_DateSubmitted = m_Alias.Members["DateSubmitted"];

          return m_DateSubmitted;
        }
      }

      private fwMember m_AttachmentFileName = null;
      public fwMember AttachmentFileName
      {
        get
        {
          if ((object)m_AttachmentFileName == null)
            m_AttachmentFileName = m_Alias.Members["AttachmentFileName"];

          return m_AttachmentFileName;
        }
      }

      private fwMember m_Users_User = null;
      public fwMember Users_User
      {
        get
        {
          if ((object)m_Users_User == null)
            m_Users_User = m_Alias.Members["Users_User"];

          return m_Users_User;
        }
      }

      private fwMember m_Categories_Category = null;
      public fwMember Categories_Category
      {
        get
        {
          if ((object)m_Categories_Category == null)
            m_Categories_Category = m_Alias.Members["Categories_Category"];

          return m_Categories_Category;
        }
      }

      private fwCollectionMember m_Eventses = null;
      public fwCollectionMember Eventses
      {
        get
        {
          if ((object)m_Eventses == null)
            m_Eventses = m_Alias.CollectionMembers["Eventses"];

          return m_Eventses;
        }
      }

    }
    
#endregion    
  }

#endregion

#region "Collection: Users"

#if !DEBUG
  [DebuggerStepThrough()]
#endif
  [Serializable]
  public partial class UsersCollection : fwProxyCollection<UsersCollection, UsersCollection.data_UsersCollection, Users, Users.data_Users>
  {

#region "Constructors"

	  static UsersCollection()
	  {
  		fwFactory.Initialise();
  	}

    [Obsolete("Please use: new UsersCollection(false);", true)]
    public UsersCollection() : base(false) {}
    public UsersCollection(bool blank) : base(blank) {}
    internal UsersCollection(bool blank, bool disconnected) : base(blank, disconnected) {}
    public UsersCollection(fwExpression expression) : base(expression) {}
    internal UsersCollection(fwExpression expression, bool disconnected) : base(expression, disconnected) {}
    public UsersCollection(data_UsersCollection innercollection) : base(innercollection) {}
    protected UsersCollection(SerializationInfo info, StreamingContext context) : base((data_UsersCollection)null)
    {
      base.DeSerialize(info, context);
    }

#endregion

#region "Interface Specific"


#endregion

#region "Members"
		
#region "Member: Requests"
    public UsersCollection IncludeRequestsEx(RequestsCollection collection)
    {
      return Include<UsersCollection, RequestsCollection>(this, collection, this.Members.UserID, collection.Members.Users_User);
    }
    public UsersCollection IncludeRequestsEx(fwExpression expression)
    {
      return IncludeRequestsEx(new RequestsCollection(expression));
    }
    public UsersCollection IncludeRequests
    {
      get { return IncludeRequestsEx(new RequestsCollection((fwExpression)null)); }
    }
    public UsersCollection ExcludeRequestsEx(RequestsCollection collection)
    {
      return Exclude<UsersCollection, RequestsCollection>(this, collection, this.Members.UserID, collection.Members.Users_User);
    }
    public UsersCollection ExcludeRequestsEx(fwExpression expression)
    {
      return ExcludeRequestsEx(new RequestsCollection(expression));
    }
    public UsersCollection ExcludeRequests
    {
      get { return ExcludeRequestsEx(new RequestsCollection((fwExpression)null)); }
    }
    public RequestsCollection JumpToRequests
    {
      get
      {
        return JumpToRequestsEx(null);
      }
    }
    public RequestsCollection JumpToRequestsEx(fwExpression expression)
    {
      RequestsCollection collection = new RequestsCollection(expression, true);
      return JumpTo<UsersCollection, RequestsCollection>(this, collection, this.Members.UserID, collection.Members.Users_User);
    }
#endregion
				
#endregion

#region "Enumerators"

    public IEnumerable<Users> Reverse { get { Refresh(); return new ReversedHandler(InnerDataCollection.Reverse); } }
    public struct ReversedHandler : IEnumerable<Users>, System.Collections.IEnumerable
    {
      internal ReversedHandler(IEnumerator<Users.data_Users> innerenum) { innerenumerator = innerenum; }
      
      IEnumerator<Users.data_Users> innerenumerator;

      System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return new ReversedEnumerator(innerenumerator); }

      public IEnumerator<Users> GetEnumerator() { return new ReversedEnumerator(innerenumerator); }
    }

#endregion

#region "InnerData"

#if !DEBUG
    [DebuggerStepThrough()]
#endif
    [fwCollection(typeof(Users.data_Users))]
    public class data_UsersCollection : fwCollection<UsersCollection ,Users.data_Users> 
    {
      [Obsolete("Please use: new data_UsersCollection(false);", true)]
      public data_UsersCollection() : base(true) { }
      internal data_UsersCollection(bool disconnected) : base(disconnected) { }
      internal data_UsersCollection(fwExpression expression, bool disconnected) : base(expression, disconnected) { }
    }

#endregion

#region "fwClass & fwMember Shortcuts"

    protected AliasMembers m_aliasmembers = null;
    public AliasMembers Members
    {
      get
      {
        if ((object)m_aliasmembers == null) m_aliasmembers = new AliasMembers(InnerDataCollection.Class);
        return m_aliasmembers;
      }
    }
    public class AliasMembers
    {

      internal AliasMembers(fwAlias alias)
      {
        m_Alias = alias;
      }
      fwAlias m_Alias = null;
    
      private fwMember m_UserID = null;
      public fwMember UserID
      {
        get
        {
          if ((object)m_UserID == null)
            m_UserID = m_Alias.Members["UserID"];

          return m_UserID;
        }
      }

      private fwMember m_Username = null;
      public fwMember Username
      {
        get
        {
          if ((object)m_Username == null)
            m_Username = m_Alias.Members["Username"];

          return m_Username;
        }
      }

      private fwMember m_Password = null;
      public fwMember Password
      {
        get
        {
          if ((object)m_Password == null)
            m_Password = m_Alias.Members["Password"];

          return m_Password;
        }
      }

      private fwMember m_Name = null;
      public fwMember Name
      {
        get
        {
          if ((object)m_Name == null)
            m_Name = m_Alias.Members["Name"];

          return m_Name;
        }
      }

      private fwMember m_Email = null;
      public fwMember Email
      {
        get
        {
          if ((object)m_Email == null)
            m_Email = m_Alias.Members["Email"];

          return m_Email;
        }
      }

      private fwMember m_Phone = null;
      public fwMember Phone
      {
        get
        {
          if ((object)m_Phone == null)
            m_Phone = m_Alias.Members["Phone"];

          return m_Phone;
        }
      }

      private fwMember m_Company = null;
      public fwMember Company
      {
        get
        {
          if ((object)m_Company == null)
            m_Company = m_Alias.Members["Company"];

          return m_Company;
        }
      }

      private fwMember m_UserType = null;
      public fwMember UserType
      {
        get
        {
          if ((object)m_UserType == null)
            m_UserType = m_Alias.Members["UserType"];

          return m_UserType;
        }
      }

      private fwCollectionMember m_Requestses = null;
      public fwCollectionMember Requestses
      {
        get
        {
          if ((object)m_Requestses == null)
            m_Requestses = m_Alias.CollectionMembers["Requestses"];

          return m_Requestses;
        }
      }

    }
    
#endregion    
  }

#endregion

}
