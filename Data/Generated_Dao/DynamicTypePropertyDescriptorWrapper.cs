using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Data;
using System.Data.Common;
using System.Linq;
using Bam.Net;
using Bam.Net.Data;
using Bam.Net.Data.Repositories;
using Newtonsoft.Json;
using Bam.Net.Data.Dynamic.Data;
using Bam.Net.Data.Dynamic.Data.Dao;

namespace Bam.Net.Data.Dynamic.Data.Wrappers
{
	// generated
	[Serializable]
	public class DynamicTypePropertyDescriptorWrapper: Bam.Net.Data.Dynamic.Data.DynamicTypePropertyDescriptor, IHasUpdatedXrefCollectionProperties
	{
		public DynamicTypePropertyDescriptorWrapper()
		{
			this.UpdatedXrefCollectionProperties = new Dictionary<string, PropertyInfo>();
		}

		public DynamicTypePropertyDescriptorWrapper(DaoRepository daoRepository) : this()
		{
			this.DaoRepository = daoRepository;
		}

		[JsonIgnore]
		public DaoRepository DaoRepository { get; set; }

		[JsonIgnore]
		public Dictionary<string, PropertyInfo> UpdatedXrefCollectionProperties { get; set; }

		protected void SetUpdatedXrefCollectionProperty(string propertyName, PropertyInfo correspondingProperty)
		{
			if(UpdatedXrefCollectionProperties != null && !UpdatedXrefCollectionProperties.ContainsKey(propertyName))
			{
				UpdatedXrefCollectionProperties.Add(propertyName, correspondingProperty);				
			}
			else if(UpdatedXrefCollectionProperties != null)
			{
				UpdatedXrefCollectionProperties[propertyName] = correspondingProperty;				
			}
		}




	}
	// -- generated
}																								
