﻿using DALayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLayer
{
    public class EmpProfileOperations
    {
        EmpProfileRepository empProfileRepository = new EmpProfileRepository(new EmsContext());

        public void insertEmpProfile(EmpProfile empProfile)
        {
            empProfileRepository.Insert(empProfile);

        }

        public List<EmpProfile> ListOfEmployee()
        {
            return empProfileRepository.GetAll().ToList();
        }

    }

}
