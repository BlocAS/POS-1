//
// Class	:	VUserRolePrimaryKey.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	5/2/2015 4:13:16 AM
//
	
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace POS.BusinessLayer
{
	[DataContract(Namespace = "POS.BusinessLayer")]
	public class VUserRolePrimaryKey
	{
		#region Data Contract (Business Object Interface To Service)
		
			[DataMember]
			public int? UserID {get;set;}
			
			[DataMember]
			public int? GroupID {get;set;}
			
			[DataMember]
			public int? Expr1 {get;set;}
			

		#endregion
	}
}

