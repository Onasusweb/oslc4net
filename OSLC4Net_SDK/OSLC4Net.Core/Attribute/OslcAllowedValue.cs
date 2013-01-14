﻿/*******************************************************************************
 * Copyright (c) 2012 IBM Corporation.
 *
 * All rights reserved. This program and the accompanying materials
 * are made available under the terms of the Eclipse Public License v1.0
 * and Eclipse Distribution License v. 1.0 which accompanies this distribution.
 *  
 * The Eclipse Public License is available at http://www.eclipse.org/legal/epl-v10.html
 * and the Eclipse Distribution License is available at
 * http://www.eclipse.org/org/documents/edl-v10.php.
 *
 * Contributors:
 *
 *     Steve Pitschke  - initial API and implementation
 *******************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSLC4Net.Core.Attribute
{
    [System.AttributeUsage(System.AttributeTargets.Method)
    ]
    public class OslcAllowedValue : System.Attribute
    {
        /**
         * A value allowed for property, inlined into property definition.
         */
        public readonly string[] value;

        public OslcAllowedValue(params string[] value)
        {
            this.value = new string[value.Length];

            value.CopyTo(this.value, 0);
        }
    }
}