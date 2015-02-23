// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNet.Cors.Core;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Security;

namespace CorsWebSite
{
    [Route("Cors/[action]/{id?}")]
    public class CorsController : Controller
    {
        [EnableCors("AllowAnySimpleRequest")]
        public ProductInfo GetProductInfo(int id)
        {
            return new ProductInfo()
            {
                Id = id,
                Description = "Dummy Product",
                Price = 5.0
            };
        }

        [EnableCors("WithCredentials")]
        [Authorize]
        public bool BuyProduct(int id)
        {
            // Product bought.
            return true;
        }
    }
}