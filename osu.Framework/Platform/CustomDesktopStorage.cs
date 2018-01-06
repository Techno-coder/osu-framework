// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

namespace osu.Framework.Platform {
    public class CustomDesktopStorage : DesktopStorage {
        internal static string basePath;

        internal CustomDesktopStorage(string baseName)
            : base(baseName) { }

        protected override string LocateBasePath() {
            return basePath;
        }
    }

    public class CustomDesktopStorageBuilder {
        public string BasePath { get; set; }
        public string BaseName { get; set; }

        public CustomDesktopStorage Build() {
            CustomDesktopStorage.basePath = BasePath;
            return new CustomDesktopStorage(BaseName);
        }
    }
}
