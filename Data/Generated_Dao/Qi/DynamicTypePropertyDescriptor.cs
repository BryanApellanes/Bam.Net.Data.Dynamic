/*
	This file was generated and should not be modified directly
*/
using System;
using System.Collections.Generic;
using System.Text;
using Bam.Net;
using Bam.Net.Data;
using Bam.Net.Data.Qi;
using Bam.Net.Data.Dynamic.Data.Dao;
using Microsoft.AspNetCore.Mvc;

namespace Bam.Net.Data.Dynamic.Data.Dao.Qi
{
    public class DynamicTypePropertyDescriptorController : DaoController
    {	
		public ActionResult Save(Bam.Net.Data.Dynamic.Data.Dao.DynamicTypePropertyDescriptor[] values)
		{
			try
			{
				DynamicTypePropertyDescriptorCollection saver = new DynamicTypePropertyDescriptorCollection();
				saver.AddRange(values);
				saver.Save();
				return Json(new { Success = true, Message = "", Dao = "" });
			}
			catch(Exception ex)
			{
				return GetErrorResult(ex);
			}
		}

		public ActionResult Create(Bam.Net.Data.Dynamic.Data.Dao.DynamicTypePropertyDescriptor dao)
		{
			return Update(dao);
		}

		public ActionResult Retrieve(long id)
        {
			try
			{
				object value = Bam.Net.Data.Dynamic.Data.Dao.DynamicTypePropertyDescriptor.OneWhere(c => c.KeyColumn == id).ToJsonSafe();
				return Json(new { Success = true, Message = "", Dao = value });
			}
			catch(Exception ex)
			{
				return GetErrorResult(ex);
			}
        }

		public ActionResult Update(Bam.Net.Data.Dynamic.Data.Dao.DynamicTypePropertyDescriptor dao)
        {
			try
			{
				dao.Save();
				return Json(new { Success = true, Message = "", Dao = dao.ToJsonSafe() });
			}
			catch(Exception ex)
			{
				return GetErrorResult(ex);
			}            
        }

		public ActionResult Delete(long id)
		{
			try
			{
				string msg = "";
				Bam.Net.Data.Dynamic.Data.Dao.DynamicTypePropertyDescriptor dao = Bam.Net.Data.Dynamic.Data.Dao.DynamicTypePropertyDescriptor.OneWhere(c => c.KeyColumn == id);				
				if(dao != null)
				{
					dao.Delete();	
				}
				else
				{
					msg = string.Format("The specified id ({0}) was not found in the table (DynamicTypePropertyDescriptor)", id);
				}
				return Json(new { Success = true, Message = msg, Dao = "" });
			}
			catch(Exception ex)
			{
				return GetErrorResult(ex);
			}
		}

		public ActionResult OneWhere(QiQuery query)
		{
			try
			{
				query.table = Bam.Net.Data.Dao.TableName(typeof(Bam.Net.Data.Dynamic.Data.Dao.DynamicTypePropertyDescriptor));
				object value = Bam.Net.Data.Dynamic.Data.Dao.DynamicTypePropertyDescriptor.OneWhere(query).ToJsonSafe();
				return Json(new { Success = true, Message = "", Dao = value });
			}
			catch(Exception ex)
			{
				return GetErrorResult(ex);
			}	 			
		}

		public ActionResult Where(QiQuery query)
		{
			try
			{
				query.table = Bam.Net.Data.Dao.TableName(typeof(Bam.Net.Data.Dynamic.Data.Dao.DynamicTypePropertyDescriptor));
				object[] value = Bam.Net.Data.Dynamic.Data.Dao.DynamicTypePropertyDescriptor.Where(query).ToJsonSafe();
				return Json(new { Success = true, Message = "", Dao = value });
			}
			catch(Exception ex)
			{
				return GetErrorResult(ex);
			}
		}

		private ActionResult GetErrorResult(Exception ex)
		{
			return Json(new { Success = false, Message = ex.Message });
		}
	}
}