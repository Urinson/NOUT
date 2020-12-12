select t1.id,t1.Last_name,t1.First_name,t1.First_name2,t1.Data,
                t1.Email,t1.Phone, t1.Adress, t2.Naimenovanie as Pol, t3.Naimenovanie as [Nosology],
                t4.Naimenovanie as Kategory from[dbo].[People] t1
                inner join[dbo].[Pol] t2 on t1.Pol = t2.id
                inner join[dbo].[Nosology] t3 on t1.Nosology=t3.id
                inner join[dbo].[Kategory] t4 on t1.Kategory=t4.id
where t1.Last_name like '%fff%'