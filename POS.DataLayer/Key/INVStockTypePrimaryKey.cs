//
// Class	:	INVStockTypePrimaryKey.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:55:59 PM
//

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;

namespace POS.DataLayer
{
	public class INVStockTypePrimaryKey
	{

	#region Class Level Variables
			private int?           	_stockTypeIDNonDefault   	= null;
	#endregion

	#region Constants

	#endregion

	#region Constructors / Destructors

		/// <summary>
		/// Constructor setting values for all fields
		/// </summary>
		public INVStockTypePrimaryKey(int? stockTypeID) 
		{
	
			
			this._stockTypeIDNonDefault = stockTypeID;

		}

		#endregion

	#region Properties

		/// <summary>
		/// This property is mapped to the "StockTypeID" field.  Mandatory.
		/// </summary>
		public int? StockTypeID
		{
			get 
			{ 
				return _stockTypeIDNonDefault;
			}
			set 
			{
			
				_stockTypeIDNonDefault = value; 
			}
		}

		#endregion

	#region Methods (Public)

		/// <summary>
		/// Method to get the list of fields and their values
		/// </summary>
		///
		/// <returns>Name value collection containing the fields and the values</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:55:59 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public NameValueCollection GetKeysAndValues() 
		{
			NameValueCollection nvc=new NameValueCollection();
			
			nvc.Add("StockTypeID",_stockTypeIDNonDefault.ToString());
			return nvc;
			
		}

		#endregion	
		
	#region Methods (Private)

	#endregion

	}
}
