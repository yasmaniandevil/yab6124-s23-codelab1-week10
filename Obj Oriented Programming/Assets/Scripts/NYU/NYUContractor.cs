using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYUContractor : NYUFaculty
{
   public bool renewedContract = false;

   public NYUContractor(string name, string netId, float salary, bool tenure, bool renewedContract) : base(name, netId, salary, tenure)
   {
      this.renewedContract = renewedContract;
      type = "NYU contractor";
   }

   public override string ShowRecord()
   {
      return base.ShowRecord() + "\nRenewed Contract: " + renewedContract;
   }
}
