//
// Class	:	INVTransferHeader.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	2/22/2015 7:27:20 PM
//
using System;
using System.Runtime.Serialization;
using POS.DataLayer;

namespace POS.BusinessLayer
{

	/// <summary>
	/// This class describes the attributes of a INVTransferHeader and is the public interface for this service.
	/// </summary>
	[DataContract(Namespace = "POS.BusinessLayer")]
	public class INVTransferHeader : INVTransferHeaderBase
	{
	}
}
			
