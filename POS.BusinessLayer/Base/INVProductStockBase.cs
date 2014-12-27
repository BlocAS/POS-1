//
// Class	:	INVProductStockBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:07 PM
//
using System;
using System.Runtime.Serialization;
using POS.DataLayer;

namespace POS.BusinessLayer
{
	/// <summary>
	/// Class for the properties of the object
	/// </summary>
	[DataContract(Namespace = "POS.BusinessLayer")]
	public class INVProductStockBase
	{

		#region Data Contract (Business Object Interface To Service)

		
		[DataMember]
		public int? ProductStockID {get;set;}

		[DataMember]
		public int? ProductID {get;set;}

		[DataMember]
		public decimal? TotalQty {get;set;}

		[DataMember]
		public int? StockTypeID {get;set;}

		[DataMember]
		public decimal? OpeningQty {get;set;}

		[DataMember]
		public DateTime? OpennigDate {get;set;}

		[DataMember]
		public DateTime? CreateDate {get;set;}

		[DataMember]
		public int? CreatedBy {get;set;}

		[DataMember]
		public DateTime? UpdateDate {get;set;}

		[DataMember]
		public int? UpdatedBy {get;set;}

		
		#endregion
	}
}
			
