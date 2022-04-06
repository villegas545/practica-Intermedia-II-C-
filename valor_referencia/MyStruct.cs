namespace valor_referencia
{
    public struct MyStruct:IMyInterface
    {
        public string V1{get;set;}
        public string V2{get;set;}
        public string V3{get;set;}
     
           public void setVariables(string v1, string v2, string v3)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
        }
    }
}