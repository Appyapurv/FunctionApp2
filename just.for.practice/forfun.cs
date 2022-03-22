//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace just.For.practice
//{
//     class forfun
//    {
//        public void Main(String[] args)
//        {

//            //int n = Convert.ToInt32(Console.ReadLine());
//            //for (int j = 0; j < n; j++)
//            //{
//            //    double total_cost = 0, prev_checkpoint = -1; double price = 1;
//            //    int cp = Convert.ToInt32(Console.ReadLine());
//            //    string checkpointp_v = Console.ReadLine();

//            //    string p = Console.ReadLine();
//            //    string[] cp_value = checkpointp_v.Split(' ');
//            //    string[] pet = p.Split(' ');
//            //    double[] checkpoint_val = new double[cp_value.Length];
//            //    double[] petrol = new double[pet.Length];
//            //    for (int i = 0; i < cp; i++)
//            //    {
//            //        checkpoint_val[i] = Convert.ToInt64(cp_value[i]);
//            //        petrol[i] = Convert.ToInt64(pet[i]);
//            //        if (i == 0)
//            //            prev_checkpoint = checkpoint_val[i];

//            //        if (prev_checkpoint < checkpoint_val[i])
//            //            total_cost = total_cost + (petrol[i] * prev_checkpoint);
//            //        else
//            //        {
//            //            prev_checkpoint = checkpoint_val[i];
//            //            total_cost = total_cost + (petrol[i] * prev_checkpoint);
//            //        }
//            //    }
//            //    Console.WriteLine(total_cost);
//            //}
//            int n = Convert.ToInt32(Console.ReadLine());
//            for (int j = 0; j < n; j++)
//            {
//                double total_cost = 0, prev_checkpoint = -1; double price = 1;
//                int checkpoint = Convert.ToInt32(Console.ReadLine());
//                string checkpoint_v = Console.ReadLine();
//                string patrol = Console.ReadLine();
//                string[] CheckpointValue = checkpoint_v.Split(' ');
//                string[] patrolValue = patrol.Split(' ');
//                double[] CheckpointVal = new double[CheckpointValue.Length];
//                double[] patrolVal = new double[patrolValue.Length];

//                for (int i = 0; i < checkpoint; i++)
//                {
//                    CheckpointVal[i] = Convert.ToInt64(CheckpointValue[i]);
//                    patrolVal[i] = Convert.ToInt64(patrolValue[i]);
//                    if (i == 0)
//                        prev_checkpoint = CheckpointVal[i];

//                    if (prev_checkpoint < CheckpointVal[i])
//                        total_cost = total_cost + (patrolVal[i] * prev_checkpoint);
//                    else
//                    {
//                        prev_checkpoint = CheckpointVal[i];
//                        total_cost = total_cost + (patrolVal[i] * prev_checkpoint);
//                    }
                   
//                }
//                Console.WriteLine(total_cost);
//            }

//        }
//    }
//}
