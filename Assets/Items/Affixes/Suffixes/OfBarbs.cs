﻿//  
//     Copyright 2017 Abel Dantas
//  
//     This file is part of item-affix-decorators.
//     http://github.com/abeldantas/item-affix-decorators
//  
//     item-affix-decorators is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
// 
//     item-affix-decorators is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
// 
//     You should have received a copy of the GNU General Public License
//     along with this program. If not, see http://www.gnu.org/licenses/

namespace ItemAffixes
{
    public class OfBarbs : ItemAffix
    {
        const string ConcreteAffixDescription = "Melee attackers take (22-39) damage per hit";
        protected override string AffixDescription { get { return ConcreteAffixDescription; } }


        public OfBarbs( Item item ) : base( item )
        {
            isPrefix = false;
        }

        public override void Use()
        {
            base.Use();
            throw new System.NotImplementedException();
        }
    }
}