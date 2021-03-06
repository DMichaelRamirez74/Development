﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FingerprintsModel
{
    public class PIRModel
    {
        public string Gen_Agency { get; set; }
        public string Gen_Address { get; set; }
        public string Gen_Phone1 { get; set; }
        public string Gen_Fax { get; set; }
        public string Gen_FName { get; set; }
        public string Gen_LName { get; set; }
        public string Gen_Email { get; set; }
        public string Gen_Grantee { get; set; }
        public string Gen_Delegate { get; set; }
        public string Gen_Zip { get; set; }
        public string Gen_ProgramType { get; set; }
        public string A_ProgramEndDate { get; set; }
        public string A_ProgramStartDate { get; set; }
        public string A_Slots { get; set; }
        public string A_SlotsOther { get; set; }
        public string A_FundQ1 { get; set; }
        public string A_FundQ2 { get; set; }
        public string A_FundQ3 { get; set; }
        public string A_FundQ4 { get; set; }
        public string A_FundQ5 { get; set; }
        public string A_FundQ6 { get; set; }
        public string A_FundQ7 { get; set; }
        public string A_FundQ8 { get; set; }
        public string A_FundQ9 { get; set; }
        public string A_FundQ10 { get; set; }
        public string A_FundQ11 { get; set; }
        public string A_FundQ12 { get; set; }
        public string A_FundQ13 { get; set; }
        public string A_FundQ14 { get; set; }
        public string A_FundQ15 { get; set; }
        public string A_FundQ16 { get; set; }
        public string A_11 { get; set; }
        public string A_12 { get; set; }
        public string A_12a { get; set; }
        public string A_13_0 { get; set; }
        public string A_13_1 { get; set; }
        public string A_13_2 { get; set; }
        public string A_13_3 { get; set; }
        public string A_13_4 { get; set; }
        public string A_13_5 { get; set; }
        public string A_13_6 { get; set; }
        public string A_14_Preg { get; set; }
        public string A_15 { get; set; }
        public string A_16A { get; set; }
        public string A_16B { get; set; }
        public string A_16C { get; set; }
        public string A_16D { get; set; }
        public string A_16E { get; set; }
        public string A_16F { get; set; }
        public string A_18A { get; set; }
        public string A_18B { get; set; }
        public string A_19 { get; set; }
        public string A_19A { get; set; }
        public string A_19B { get; set; }
        public string A_20 { get; set; }
        public string A_20A { get; set; }
        public string A_20B { get; set; }
        public string A_20B_1 { get; set; }
        public string A_20B_2 { get; set; }
        public string A_20B_3 { get; set; }
        public string A_21 { get; set; }
        public string A_22 { get; set; }
        public string A_22_A { get; set; }
        public string A_22_B { get; set; }
        public string A_24 { get; set; }
        public string A_25a1 { get; set; }
        public string A_25a2 { get; set; }
        public string A_25b1 { get; set; }
        public string A_25b2 { get; set; }
        public string A_25c1 { get; set; }
        public string A_25c2 { get; set; }
        public string A_25d1 { get; set; }
        public string A_25d2 { get; set; }
        public string A_25e1 { get; set; }
        public string A_25e2 { get; set; }
        public string A_25f1 { get; set; }
        public string A_25f2 { get; set; }
        public string A_25g1 { get; set; }
        public string A_25g2 { get; set; }
        public string A_25h1 { get; set; }
        public string A_25h2 { get; set; }
        public string A_26a { get; set; }
        public string A_26b { get; set; }
        public string A_26c { get; set; }
        public string A_26d { get; set; }
        public string A_26e { get; set; }
        public string A_26f { get; set; }
        public string A_26g { get; set; }
        public string A_26h { get; set; }
        public string A_26i { get; set; }
        public string A_26j { get; set; }
        public string A_26k { get; set; }
        public string A_27 { get; set; }
        public string A_27A { get; set; }


        public string C_1_1 { get; set; }
        public string C_1_2 { get; set; }
        public string C_A_1 { get; set; }
        public string C_A_2 { get; set; }
        public string C_B_1 { get; set; }
        public string C_B_2 { get; set; }
        public string C_C_1 { get; set; }
        public string C_C_2 { get; set; }
        public string C_D_1 { get; set; }
        public string C_D_2 { get; set; }
        public string C_2_1 { get; set; }
        public string C_2_2 { get; set; }
        public string C_3_1 { get; set; }
        public string C_3_2 { get; set; }
        public string C_3A_1 { get; set; }
        public string C_3A_2 { get; set; }
        public string C_3B_1 { get; set; }
        public string C_3B_2 { get; set; }
        public string C_3C_1 { get; set; }
        public string C_3C_2 { get; set; }
        public string C_3D_1 { get; set; }
        public string C_3D_2 { get; set; }
        public string C_4_1 { get; set; }
        public string C_4_2 { get; set; }

        public string C_5_1 { get; set; }
        public string C_5_2 { get; set; }
        public string C_6_1 { get; set; }
        public string C_6_2 { get; set; }
        public string C_8_1 { get; set; }
        public string C_8_2 { get; set; }

        public string C_8_A { get; set; }
        public string C_8_A_1 { get; set; }
        public string C_9_A { get; set; }
        public string C_9_B { get; set; }
        public string C_9_C { get; set; }
        public string C_9_D { get; set; }
        public string C_9_E { get; set; }
        public string C_9_F { get; set; }
        public string C_10_A { get; set; }
        public string C_10_B { get; set; }
        public string C_10_C { get; set; }
        public string C_10_D { get; set; }
        public string C_11_1 { get; set; }
        public string C_11_2 { get; set; }
        public string C_12_1 { get; set; }
        public string C_12_2 { get; set; }
        public string C_13_1 { get; set; }
        public string C_13_2 { get; set; }


        public string C_14_A { get; set; }
        public string C_14_B { get; set; }
        public string C_14_C { get; set; }
        public string C_14_D { get; set; }
        public string C_14_E { get; set; }
        public string C_14_F { get; set; }
        public string C_14_G { get; set; }
        public string C_15_A { get; set; }
        public string C_15_B { get; set; }
        public string C_15_C { get; set; }
        public string C_16 { get; set; }

        public string C_17_1 { get; set; }
        public string C_17_2 { get; set; }
        public string C_18 { get; set; }
        public string C_19 { get; set; }
        public string C_19_A { get; set; }
        public string C_19_A_1 { get; set; }
        public string C_20 { get; set; }
        public string C_21 { get; set; }
        public string C_25 { get; set; }
        public string C_25_A { get; set; }
        public string C_25_A_1 { get; set; }
        public string C_25_A_2 { get; set; }
        public string C_25_B { get; set; }
        public string C_26 { get; set; }
        public string C_26_A { get; set; }
        public string C_26_A_1 { get; set; }
        public string C_26_A_2 { get; set; }
        public string C_26_B { get; set; }
        public string C_27_1 { get; set; }
        public string C_27_2 { get; set; }
        public string C_27_A_1 { get; set; }
        public string C_27_A_2 { get; set; }
        public string C_27_B_1 { get; set; }
        public string C_27_B_2 { get; set; }
        public string C_27_C_1 { get; set; }
        public string C_27_C_2 { get; set; }
        public string C_27_D_1 { get; set; }
        public string C_27_D_2 { get; set; }
        public string C_27_E_1 { get; set; }
        public string C_27_E_2 { get; set; }
        public string C_27_F_1 { get; set; }
        public string C_27_F_2 { get; set; }
        public string C_27_G_1 { get; set; }
        public string C_27_G_2 { get; set; }
        public string C_27_H_1 { get; set; }
        public string C_27_H_2 { get; set; }
        public string C_27_I_1 { get; set; }
        public string C_27_I_2 { get; set; }
        public string C_27_J_1 { get; set; }
        public string C_27_J_2 { get; set; }
        public string C_27_K_1 { get; set; }
        public string C_27_K_2 { get; set; }
        public string C_27_L_1 { get; set; }
        public string C_27_L_2 { get; set; }
        public string C_27_M_1 { get; set; }
        public string C_27_M_2 { get; set; }
        public string C_35 { get; set; }
        public string C_35_A { get; set; }
        public string C_35_B { get; set; }
        public string C_36_A { get; set; }
        public string C_36_B { get; set; }
        public string C_36_C { get; set; }
        public string C_36_D { get; set; }
        public string C_36_E { get; set; }
        public string C_37_A { get; set; }
        public string C_37_B { get; set; }
        public string C_37_C { get; set; }
        public string C_37_D { get; set; }
        public string C_37_E { get; set; }
        public string C_37_F { get; set; }
        public string C_38_A { get; set; }
        public string C_38_B { get; set; }
        public string C_38_C { get; set; }
        public string C_39_A { get; set; }
        public string C_39_B { get; set; }
        public string C_40_A { get; set; }
        public string C_40_B { get; set; }
        public string C_41_1 { get; set; }
        public string C_41_2 { get; set; }
        public string C_42_1 { get; set; }
        public string C_42_2 { get; set; }
        public string C_43_1 { get; set; }
        public string C_43_2 { get; set; }
        public string C_44_1 { get; set; }
        public string C_44_2 { get; set; }
        public string C_45_A { get; set; }
        public string C_45_B { get; set; }
        public string C_45_C { get; set; }
        public string C_46_A { get; set; }
        public string C_46_B { get; set; }
        public string C_47_A { get; set; }
        public string C_47_B { get; set; }
        public string C_47_C { get; set; }
        public string C_47_D { get; set; }
        public string C_48 { get; set; }
        public string C_49_A { get; set; }
        public string C_49_B { get; set; }
        public string C_49_C { get; set; }
        public string C_49_D { get; set; }
        public string C_50_A_1 { get; set; }
        public string C_50_A_2 { get; set; }
        public string C_50_B_1 { get; set; }
        public string C_50_B_2 { get; set; }
        public string C_50_C_1 { get; set; }
        public string C_50_C_2 { get; set; }
        public string C_50_D_1 { get; set; }
        public string C_50_D_2 { get; set; }
        public string C_50_E_1 { get; set; }
        public string C_50_E_2 { get; set; }
        public string C_50_F_1 { get; set; }
        public string C_50_F_2 { get; set; }
        public string C_50_G_1 { get; set; }
        public string C_50_G_2 { get; set; }
        public string C_50_H_1 { get; set; }
        public string C_50_H_2 { get; set; }
        public string C_50_I_1 { get; set; }
        public string C_50_I_2 { get; set; }
        public string C_50_J_1 { get; set; }
        public string C_50_J_2 { get; set; }
        public string C_50_K_1 { get; set; }
        public string C_50_K_2 { get; set; }
        public string C_50_L_1 { get; set; }
        public string C_50_L_2 { get; set; }
        public string C_50_M_1 { get; set; }
        public string C_50_M_2 { get; set; }
        public string C_50_N_1 { get; set; }
        public string C_50_N_2 { get; set; }
        public string C_50_O_1 { get; set; }
        public string C_50_O_2 { get; set; }
        public string C_50_P_1 { get; set; }
        public string C_50_P_2 { get; set; }
        public string C_51_1 { get; set; }
        public string C_51_2 { get; set; }
        public string C_52_A { get; set; }
        public string C_52_B { get; set; }
        public string C_52_C { get; set; }
        public string C_52_D { get; set; }
        public string C_52_E { get; set; }
        public string C_53 { get; set; }
        public string C_54 { get; set; }
        public string C_55 { get; set; }
        public string C_56 { get; set; }
        public string C_57 { get; set; }
        public string B1_1 { get; set; }
        public string B1_2 { get; set; }
        public string B1A_1 { get; set; }
        public string B1A_2 { get; set; }
        public string B1B_1 { get; set; }
        public string B1B_2 { get; set; }
        public string B1B_1_1 { get; set; }
        public string B1B_1_2 { get; set; }
        public string B3A_1 { get; set; }
        public string B3A_2 { get; set; }
        public string B3B_1 { get; set; }
        public string B3B_2 { get; set; }
        public string B3C_1 { get; set; }
        public string B3C_2 { get; set; }
        public string B3D_1 { get; set; }
        public string B3D_2 { get; set; }
        public string B3E_1 { get; set; }
        public string B3E_2 { get; set; }
        public string B3F_1 { get; set; }
        public string B3F_2 { get; set; }
        public string B3G_1 { get; set; }
        public string B3G_2 { get; set; }

        
        public string pirQuestion { get; set; }
        public string clientName { get; set; }
       
            public string DOB { get; set; }
            public string center { get; set; }
            public string classroom { get; set; }
            public string piratenrollment { get; set; }
            public string piratenrollmentDesc { get; set; }
            public string pirafterenrollment { get; set; }
            public string pirafterenrollmentDesc { get; set; }
            public string program { get; set; }
            public string clientStatus { get; set; }
            public List<PIRModel> PIRlst { get; set; }

       
    }
}
