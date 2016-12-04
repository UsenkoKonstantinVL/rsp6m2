
namespace indikator_rsp_6m2
{

  public static class TargManager
    {
        public static target Targ1 = new target(1, 144, 225, 4);
        public static target Targ2 = new target(2, 335, 180, 3);
        public static target Targ3 = new target(3, 5, 180, 2);

        public static void refr(bool NaprPas)
        {
            if (NaprPas)
            {
                Targ2 = new target(2, 335, 180, 1);
                Targ3 = new target(3, 5, 180, 0);
            }
            else
            {
                Targ2 = new target(2, 335, 180, 3);
                Targ3 = new target(3, 5, 180, 2);
            }
               Targ1 = new target(1, 144, 225, 4);
        
}
}
 }