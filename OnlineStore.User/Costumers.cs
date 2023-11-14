﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.User
{
    public class Costumers
    {
        #region Attributes

        const int MAXCOSTUMERS = 100;
        private int numCostumers;
        Costumer[] costumers;

        #endregion


        #region Methods

        #region Constructors

        public Costumers()
        {
            costumers = new Costumer[MAXCOSTUMERS];
            InitializeArrayCostumers(costumers);
        }


        #endregion


        #region OtherMethods

        void InitializeArrayCostumers(Costumer[] costumers)
        {
            for (int i = 0; i < costumers.Length; i++)
            {
                costumers[i] = new Costumer();

            }
        }

        public bool AddCostumer(Costumer costumer)
        {
            foreach (Costumer c in costumers)
            {
                if (c.Nif == 0)
                    continue;
                if (c.Equals(costumer) || (numCostumers >= MAXCOSTUMERS))
                    return false;
            }
            costumers[numCostumers] = costumer;
            numCostumers++;
            return true;
        }

        public bool DeleteAllCostumers()
        {
            for (int i = 0; i < costumers.Length; i++)
            {
                if (costumers[i].Nif is 0) continue;
                else costumers[i] = new Costumer();
            }
            return true;
        }

        public bool DeleteCostumer(Costumer c)
        {
            for (int i = 0; i < costumers.Length; i++)
            {
                if (costumers[i].Equals(c))
                {
                    for (int j = i; j < costumers.Length; j++)
                        costumers[j] = costumers[j + i];
                    costumers[costumers.Length - 1] = new Costumer();
                    return true;
                }
            }
            return false;
        }

            #endregion

            #endregion
        }
    }
