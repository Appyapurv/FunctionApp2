//namespace just.For.practice
//{
//    public static class PropertyCopyier<TParent, TChild> where TParent : class where TChild : class
//    {
//        public static void copy(TParent parent, TChild child)
//        {
//            var parentPropertys = parent.GetType().GetProperties();
//            var childPropertys = child.GetType().GetProperties();

//            foreach (var parentProperty in parentPropertys)
//            {

//                foreach (var childProperty in childPropertys)
//                {
//                    if (parentProperty.Name == childProperty.Name && parentProperty.PropertyType == childProperty.PropertyType)
//                    {
//                        childProperty.SetValue(child, parentProperty.GetValue(parent));
//                        break;
//                    }
//                }
//            }
//        }
//    }
//}
