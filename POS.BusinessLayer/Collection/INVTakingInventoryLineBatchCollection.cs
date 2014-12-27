//
// Class	:	INVTakingInventoryLineBatchCollection.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:16 PM
//

using System.Runtime.Serialization;
using System.Collections.Generic;
using POS.DataLayer;

namespace POS.BusinessLayer
{
	[CollectionDataContract(Namespace = "POS.BusinessLayer")]
	public class INVTakingInventoryLineBatchCollection : List<INVTakingInventoryLineBatch>
	{
	}
}
			
