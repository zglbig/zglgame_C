﻿namespace org.zgl
{
    public class IoMessagePBTypeImpl : IoMessage
    {
        /**接口名*/
        public string interfaceName;
        /**方法名*/
        public string methodName;
        /**参数*/
        public byte[] args;

        public object getData()
        {
            return args;
        }

        public string getInterfaceName()
        {
            return interfaceName;
        }

        public string getMethodName()
        {
            return methodName;
        }
    }
}