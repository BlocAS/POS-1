//
// Class	:	PURPurchaseReturnHeader.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:12 PM
//

using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Collections;
using System.Data.Common;

namespace POS.DataLayer
{
	
	/// <summary>
	/// Data access class for the "PURPurchaseReturnHeader" table.
	/// </summary>
	[Serializable]
	public class PURPurchaseReturnHeader : PURPurchaseReturnHeaderBase
	{
	
		#region Class Level Variables

		#endregion
		
		#region Constants
		
		#endregion

		#region Constructors / Destructors 
		
		public PURPurchaseReturnHeader() : base()
		{
		}

		#endregion

		#region Properties

		#endregion

		#region Methods (Public)
        public static bool DeleteOrder(int PurchaseHeaderID, int UserID)
        {
            DatabaseHelper oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;
            // Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
            oDatabaseHelper.AddParameter("@UserID", UserID);
            oDatabaseHelper.AddParameter("@SlaesReturnHeaderID", PurchaseHeaderID);
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
            oDatabaseHelper.ExecuteScalar("usp_PURPurchaseReturnHader_DeleteOrder", ref ExecutionState);
            oDatabaseHelper.Dispose();
            return ExecutionState;
        }

        public static bool CloseOrder(int PurchaseHeaderID, int UserID)
        {
            DatabaseHelper oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;
            // Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
            oDatabaseHelper.AddParameter("@UserID", UserID);
            oDatabaseHelper.AddParameter("@PurchaseHeaderID", PurchaseHeaderID);
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
            oDatabaseHelper.ExecuteScalar("usp_PURPurchaseReturnHader_CloseOrder", ref ExecutionState);
            oDatabaseHelper.Dispose();
            return ExecutionState;
        }
		#endregion
		
		#region Methods (Private)

		#endregion

	}
	
}
