using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYUAdjunct : NYUFaculty
{
    public float otherJobsAmt;

    public NYUAdjunct(string name, string netId, float salary, bool tenure, float otherJobsAmt) : base(name, netId,
        salary, tenure)
    {
        this.otherJobsAmt = otherJobsAmt;
        type = "NYU Adjunct";
    }

    public override string ShowRecord()
    {
        return base.ShowRecord() + "\nOther Jobs: " + otherJobsAmt;
    }
}
