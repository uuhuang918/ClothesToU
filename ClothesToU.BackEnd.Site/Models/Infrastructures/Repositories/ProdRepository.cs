﻿using ClothesToU.BackEnd.Site.Models.Entities;
using ClothesToU.BackEnd.Site.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothesToU.BackEnd.Site.Models.Infrastructures.Repositories
{
	public class ProdRepository : IProdRepository
	{
		public void Create(ProdEntity entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(int prodId)
		{
			throw new NotImplementedException();
		}

		public ProdEntity Load(int prodId)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<ProdEntity> Search(string name, string description)
		{
			throw new NotImplementedException();
		}

		public void Update(ProdEntity entity)
		{
			throw new NotImplementedException();
		}
	}
}