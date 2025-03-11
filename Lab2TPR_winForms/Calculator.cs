using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Xml;

class Calculator
{
    public DataSet DS;

    public Calculator(DataSet newDS)
    {
        DS = newDS;
    }

    public void ChangeDS(DataSet new_DS)
    {
        DS = new_DS;
    }

    public DataTable Calculate(int amount_of_res)
    {
        DataTable results = new DataTable();
        results.Clear();
        for(int i = 0; i < 2; i++)
        {
            results.Columns.Add(i.ToString());
        }
        for (int i = 0; i < amount_of_res; i++)
        {
            DataRow row = results.NewRow();
            for (int j = 0; j < 2; j++)
            {
                row[j] = 0;
            }
            results.Rows.Add(row);
        }

        double sum = 0;

        for (int i = 1; i <= amount_of_res; i++)
        {
            results.Rows[i - 1][0] = Calculate_r(i);
            sum += Convert.ToDouble(results.Rows[i - 1][0]);
        }
        results.Rows[0][1] = sum; 
        return results;
    }

    double Calculate_r(int res) 
    { 
        double r = 0;
        List<double> P_k = Calculate_All_Pk(res); 
        for(int i = 0; i < P_k.Count; i++)
        {
            r += P_k[i] * Convert.ToDouble(DS.Tables["K" + res.ToString()].Rows[i][1]);
        }
        return r;
    }

    List<Double> Calculate_All_Pk(int res)
    {
        List<Double> result = new List<Double>();
        int i = 0;
        int amount_of_k = DS.Tables["K" + res.ToString()].Rows.Count;
        while (i < amount_of_k)
        {
            result.Add(Calculate_Pk(i, "I" + res.ToString(), "P" + res.ToString(), "S_IP" + res.ToString(), "S_PK" + res.ToString()));
            i++;
        }
        return result;
    }

    public double Calculate_Pk(int k_num, string i_table, string p_table, string s_ip_table, string s_pk_table)
    {

        int i_events = DS.Tables[i_table].Rows.Count;
        int p_events = DS.Tables[p_table].Rows.Count;

        DataTable probs = new DataTable();
        probs.Clear();

        for (int i = 0; i < p_events; i++)
        {
            probs.Columns.Add(i.ToString());
        }
        for (int i = 0; i < i_events; i++)
        {
            probs.Rows.Add(i.ToString());
        }
        for (int i = 0; i < p_events; i++)
        {
            for (int j = 0; j < i_events; j++)
            {
                probs.Rows[j][i] = 0;
            }
        }

        for (int j = 0; j < p_events; j++)
        {
            if (Convert.ToInt32(DS.Tables[s_pk_table].Rows[j][k_num]) == 1)
            {
                for (int i = 0; i < i_events; i++)
                {
                    if (Convert.ToInt32(DS.Tables[s_ip_table].Rows[i][j]) == 1)
                    {
                        probs.Rows[i][j] = Convert.ToDouble(DS.Tables[i_table].Rows[i][1]);
                    }
                }
            }
        }

        List<double> temp = new List<double>();
        List<double> p_probs = RecurP(0, probs, temp, 1);
        double product = 1;
        double result = 1;

        for (int i = 0; i < p_probs.Count; i++)
        {
            product *= (1 - p_probs[i]);  
        }
        result -= product;
        return result;
    }

    List<double> RecurP(int cur_p, DataTable probs, List<double> result, double product)
    {
        if(cur_p >= probs.Columns.Count)
        {
            result.Add(product);
            return result;
        }
        for (int i = 0; i < probs.Rows.Count; i++)
        {
            if (Convert.ToDouble(probs.Rows[i][cur_p]) != 0)
            {
                product *= Convert.ToDouble(probs.Rows[i][cur_p]);
                result = RecurP(cur_p + 1, probs, result, product);
            }
        }
        return result;
    }
}