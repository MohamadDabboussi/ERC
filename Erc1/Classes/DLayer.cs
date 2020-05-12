﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erc1.model;
using System.Collections;
using System.Data;


namespace Erc1.Classes
{
    class mission
    {


        // get centers id (column name =".الرمز")
        public static IEnumerable GetCenter()
        {
            using (var entity = new ERCEntities())
            {
                //return c.ToList();
                var c = entity.المراكز.Select(r =>new { r.الرمز });
                return c.ToList();
            }
        }




        // city name of center
        public static IEnumerable GetCenterCity()
        {

            using (ERCEntities entity = new ERCEntities())
            {
                var c = (
                from centers in entity.المراكز
                join city in entity.المدن 
                on centers.المدينة equals city. رمز
                select new
                {
                    city = city.المدينة,
                    centers = centers.الرمز
                }
                    ); ;
                return c.ToList();
            };
        }



        // cars of a center by id 
        public static IEnumerable Getالآليات(int marakez)
        {

            using (ERCEntities entity = new ERCEntities())
            {
                var c = (
                from cars in entity.الآليات
                where cars.المركز == marakez
                select new
                {
                    cars = cars.موديل_
                }
                    ); ;
                return c.ToList();
            };

        }

        // add mission
        public static void AddMission(int الرمز_الشهري, DateTime التاريخ, int الآلية, int المريض, Nullable<int> من_مشفى, Nullable<int> من_القسم, Nullable<int> الطبيب_المعالج,
             Nullable<int> الجهة_الضامنة, Nullable<int> إلى_مشفى, Nullable<int> إلى_القسم, int مسؤول_المهمة, int مسعف_1, int مسعف_2,
            int السائق, Nullable<int> المتصل, string الهاتف, Nullable<int> متلقي_المهمة, int رمز_الحالة, string رمز_السنوي,
            int السنة, string تفاصيل_ال_من, string تفاصيل_ال_الى, Nullable<int> من_رمز_المدينة, Nullable<int> من_رمز_المنطقة,
            Nullable<int> الى_رمز_المدينة, Nullable<int> الى_رمز_المنطقة, string التفاصيل, string اسم_المتصل,
            int طبيعة_المهمة, int رمز__المركز)
        {
            using (ERCEntities entity = new model.ERCEntities())
            {
                المهمات_المنفذة newmission = new المهمات_المنفذة()
                {
                    الرمز_الشهري = الرمز_الشهري,
                    التاريخ = التاريخ,
                    الآلية = الآلية,
                    المريض = المريض,
                    من_مشفى = من_مشفى,
                    من_القسم = من_القسم,
                    الطبيب_المعالج = الطبيب_المعالج,
                    الجهة_الضامنة = الجهة_الضامنة,
                    إلى_مشفى = إلى_مشفى,
                    إلى_القسم = إلى_القسم,
                    مسؤول_المهمة = مسؤول_المهمة,
                    مسعف_1 = مسعف_1,
                    مسعف_2 = مسعف_2,
                    السائق = السائق,
                    المتصل = المتصل,
                    الهاتف = الهاتف,
                    متلقي_المهمة = متلقي_المهمة,
                    رمز_السنوي = رمز_السنوي,
                    السنة = السنة,
                    تفاصيل_ال_من = تفاصيل_ال_من,
                    تفاصيل_ال_الى = تفاصيل_ال_الى,
                    من_رمز_المدينة = من_رمز_المدينة,
                    من_رمز_المنطقة = من_رمز_المنطقة,
                    الى_رمز_المدينة = الى_رمز_المدينة,
                    الى_رمز_المنطقة = الى_رمز_المنطقة,
                    التفاصيل = التفاصيل,
                    اسم_المتصل = اسم_المتصل,
                    طبيعة_المهمة = طبيعة_المهمة,
                    رمز__المركز = رمز__المركز
                };
                entity.المهمات_المنفذة.Add(newmission);
                entity.SaveChanges();
            };
        }

    }
    
}
