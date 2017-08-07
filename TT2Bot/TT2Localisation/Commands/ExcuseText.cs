﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT2Bot
{
    public static partial class TT2Localisation
    {
        public static partial class Commands
        {
            public static class ExcuseText
            {
                private const string BASE_PATH = Commands.BASE_PATH + "EXCUSE_";

                public const string SELF = BASE_PATH + nameof(SELF);
                public const string ID = BASE_PATH + nameof(ID);
                public const string REASON = BASE_PATH + nameof(REASON);
                public const string ADD_SUCCESS = BASE_PATH + nameof(ADD_SUCCESS);
                public const string REMOVE_NOTFOUND = BASE_PATH + nameof(REMOVE_NOTFOUND);
                public const string REMOVE_NOTOWN = BASE_PATH + nameof(REMOVE_NOTOWN);
                public const string REMOVE_SUCCESS = BASE_PATH + nameof(REMOVE_SUCCESS);

                public static IReadOnlyDictionary<string, string> Defaults { get; }
                    = new Dictionary<string, string>
                    {
                        { SELF, "Haha! You must be mistaken, I never miss a Titan Lord attack." },
                        { ID, "Excuse #{0}" },
                        { REASON, "<@{0}> didnt attack the boss because:" },
                        { ADD_SUCCESS, "Added the excuse as #{0}" },
                        { REMOVE_NOTFOUND, "There is no excuse with that ID" },
                        { REMOVE_NOTOWN, "You do not own this excuse." },
                        { REMOVE_SUCCESS, "Removed excuse #{0}" },
                    }.ToImmutableDictionary();
            }
        }
    }
}
