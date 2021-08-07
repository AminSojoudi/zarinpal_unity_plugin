using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZarinpalConfig : ScriptableObject
{
    public string MerchantID;
    public bool AutoVerifyPurchase = true;
    public string Scheme = "return";
    public string Host = "zarinpalpayment";
    public bool LogEnabled = true;
    public bool Enable = true;
}
