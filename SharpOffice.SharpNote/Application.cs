﻿using SharpOffice.Core;

namespace SharpOffice.SharpNote
{
    public class Application : IApplication
    {
        public string Name
        {
            get { return "SharpNote"; }
        }

        public void RegisterCustomTypes(DryIoc.Container container)
        {
            
        }
    }
}