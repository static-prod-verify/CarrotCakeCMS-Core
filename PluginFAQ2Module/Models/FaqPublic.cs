﻿using CarrotCake.CMS.Plugins.FAQ2.Data;
using Carrotware.CMS.Interface;
using System.ComponentModel;

namespace CarrotCake.CMS.Plugins.FAQ2.Models {

	public class FaqPublic : WidgetActionSettingModel {

		public FaqPublic() {
			this.FaqCategoryID = Guid.Empty;
		}

		public override bool EnableEdit {
			get {
				return true;
			}
		}

		[Description("FAQ to display")]
		[Widget(WidgetAttribute.FieldMode.DropDownList, "lstFAQID")]
		public Guid FaqCategoryID { get; set; }

		[Widget(WidgetAttribute.FieldMode.DictionaryList)]
		public Dictionary<string, string> lstFAQID {
			get {
				Dictionary<string, string> _dict = null;

				using (FaqHelper fh = new FaqHelper(this.SiteID)) {
					_dict = (from c in fh.CategoryListGetBySiteID(this.SiteID)
							 orderby c.FaqTitle
							 select c).ToList().ToDictionary(k => k.FaqCategoryId.ToString(), v => v.FaqTitle);
				}

				return _dict;
			}
		}

		public override void LoadData() {
			base.LoadData();

			if (this.PublicParmValues.Count > 0) {
				try {
					string sFoundVal = GetParmValue("FaqCategoryID", Guid.Empty.ToString());

					if (!string.IsNullOrEmpty(sFoundVal)) {
						this.FaqCategoryID = new Guid(sFoundVal);
					}
				} catch (Exception ex) { }
			}
		}

		public List<CarrotFaqItem> GetList() {
			using (FaqHelper fh = new FaqHelper(this.SiteID)) {
				return fh.FaqItemListPublicGetByFaqCategoryID(this.FaqCategoryID, this.SiteID);
			}
		}

		public List<CarrotFaqItem> GetListTop(int takeTop) {
			using (FaqHelper fh = new FaqHelper(this.SiteID)) {
				return fh.FaqItemListPublicTopGetByFaqCategoryID(this.FaqCategoryID, this.SiteID, takeTop);
			}
		}

		public CarrotFaqCategory GetFaq() {
			using (FaqHelper fh = new FaqHelper(this.SiteID)) {
				return fh.CategoryGetByID(this.FaqCategoryID);
			}
		}

		public CarrotFaqItem GetRandomItem() {
			using (FaqHelper fh = new FaqHelper(this.SiteID)) {
				return fh.FaqItemListPublicRandGetByFaqCategoryID(this.FaqCategoryID, this.SiteID);
			}
		}
	}
}