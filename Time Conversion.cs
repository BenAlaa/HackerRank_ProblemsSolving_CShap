static string timeConversion(string s)
{
    int xx = 0;
    string militaryFormat = "hh:mm:ss";
    string hh = s[0].ToString() + s[1].ToString();
    string mm = s[3].ToString() + s[4].ToString();
    string ss = s[6].ToString() + s[7].ToString();
    char type = s[8];
    if ( type == 'A')
    {
        if (hh == "12")
        {
            hh = "00";
        }
    }
    else if (type == 'P')
    {
        xx = Convert.ToInt32(hh);
        if (xx != 12)
        {
            xx = xx + 12;
            hh = xx.ToString();
        }
        
    }

    //Console.Write("{0}:{1}:{2}", hh, mm, ss);
    militaryFormat = hh + ":" + mm + ":" + ss;
    return militaryFormat;

}