using System;
using System.Collections.Generic;
using XRayBuilder.Core.DataSources.Secondary;
using XRayBuilder.Core.DataSources.Secondary.Model;
using XRayBuilder.Core.Libraries;
using XRayBuilder.Core.XRay.Artifacts;
using XRayBuilder.Core.XRay.Model;

namespace XRayBuilder.Core.XRay
{
    public sealed class XRay
    {
        public readonly string DataUrl = "";
        public readonly string DatabaseName;
        private string _guid = "";
        public readonly string Asin;
        public List<Term> Terms = new List<Term>(100);
        public List<Chapter> Chapters = new List<Chapter>();
        public readonly List<Excerpt> Excerpts = new List<Excerpt>();
        public long Srl;
        public long Erl;
        public readonly bool SkipShelfari;
        public bool Unattended { get; set; }
        public List<NotableClip> NotableClips;
        public int FoundNotables;
        public DateTime? CreatedAt { get; set; }

        public readonly ISecondarySource DataSource;

        public XRay(string shelfari, string db, string guid, string asin, ISecondarySource dataSource)
        {
            if ((shelfari == "" && !(dataSource is SecondarySourceRoentgen)) || guid == "" || asin == "")
                throw new ArgumentException("Error initializing X-Ray, one of the required parameters was blank.");

            if (!shelfari.ToLower().StartsWith("http://") && !shelfari.ToLower().StartsWith("https://"))
                shelfari = "https://" + shelfari;
            DataUrl = shelfari;
            DatabaseName = string.IsNullOrEmpty(db) ? null : db;
            if (guid != null)
                Guid = guid;
            Asin = asin;
            DataSource = dataSource;
        }

        public string Guid
        {
            private set => _guid = Functions.ConvertGuid(value);
            get => _guid;
        }
    }
}
