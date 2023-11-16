using MUAYENETAKIP.DBOBECT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MUAYENETAKIP.DBOBECT;

namespace MUAYENETAKIP
{
    public partial class anabilimdali : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                veriListele();
            }
        }
        
        private void anabilimDaliEkle()
        {
            try
            {
                using (DBOBECT.MUAYNETAKIPDBEntities dbContext = new DBOBECT.MUAYNETAKIPDBEntities())
                {
                    ANABILIMDALI aANABILIMDALI = new ANABILIMDALI();
                    aANABILIMDALI.ADI = txtAdi.Text;
                    if (txtAciklama.Text != String.Empty)
                    {
                        aANABILIMDALI.ACIKLAMA = txtAciklama.Text;
                    }
                    else
                    {
                        aANABILIMDALI.ACIKLAMA = null;
                    }

                    dbContext.ANABILIMDALI.Add(aANABILIMDALI);
                    dbContext.SaveChanges();

                    sonucLbl.Text = "Anabilim Dalı Kaydedildi!!";
                }


            }
            catch (Exception ex)
            {
                sonucLbl.Text = "Hata Oluştu Tekrar Deneyiniz! " + ex.Message;
            }
            finally
            {
                veriListele();
            }
        }

        protected void kaydetBtn_Click(object sender, EventArgs e)
        {
            if(kaydetBtn.CommandName == "KAYDET")
            {
                anabilimDaliEkle();
            }
            else if (kaydetBtn.CommandName == "Düzenle")
            {
                int ID = Convert.ToInt32(kaydetBtn.CommandArgument);
                veriGuncelle(ID);
            }
            

        }

        private void veriListele()
        {
            try
            {
                using (MUAYNETAKIPDBEntities dbContext = new MUAYNETAKIPDBEntities())
                {
                    List<ANABILIMDALI> AnabilimDaliListe = dbContext.ANABILIMDALI.ToList();

                    gridListe.DataSource = AnabilimDaliListe;
                    gridListe.DataBind();
                }
            }
            catch (Exception ex)
            {
                sonucLbl.Text = "Hata Oluştu Tekrar Deneyiniz! " + ex.Message;
            }
        }

        protected void gridListe_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if(e.CommandName == "SİL")
                {
                    int SatirNumarasi = Convert.ToInt32(e.CommandArgument);
                    int ID = Convert.ToInt32(gridListe.DataKeys[SatirNumarasi].Value);
                    VeriSil(ID);
                }else if(e.CommandName == "Düzenle") {
                    int SatirNumarasi = Convert.ToInt32(e.CommandArgument);
                    int ID = Convert.ToInt32(gridListe.DataKeys[SatirNumarasi].Value);
                    VeriSec(ID);
                }
            }
            catch (Exception ex){ 
                sonucLbl.Text = ex.Message;
            }
        }

        private void VeriSil(int ID)
        {
            try
            {
                using (DBOBECT.MUAYNETAKIPDBEntities dbContext = new DBOBECT.MUAYNETAKIPDBEntities())
                {
                    // SELECT TOP(1) * FROM ANABILIMDALI WHERE ANABILIMDALIID = ID;

                    ANABILIMDALI aNABILIMDALI =
                        dbContext.ANABILIMDALI.Where(x => x.ANABILIMDALIID == ID).FirstOrDefault();

                    dbContext.ANABILIMDALI.Remove(aNABILIMDALI);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                sonucLbl.Text = e.Message;
            }
            finally
            {
                veriListele();
            }
        }
        
        private void frmTemizle()
        {
            txtAdi.Text = String.Empty;
            txtAciklama.Text = String.Empty;
            kaydetBtn.CommandName = "KAYDET";
            kaydetBtn.CommandArgument = String.Empty;
            kaydetBtn.Text = "KAYDET";
        }

        protected void btnTemizle_Click(object sender, EventArgs e)
        {
            frmTemizle();
        }

        private void VeriSec( int ID)
        {
            try
            {
                using (MUAYNETAKIPDBEntities dbContext = new MUAYNETAKIPDBEntities())
                {
                    // select * from anabilimdali a where a.ANABILIMDALID = ID
                   ANABILIMDALI aANABILIMDALI = 
                        dbContext.ANABILIMDALI.Where(x => x.ANABILIMDALIID == ID).FirstOrDefault();
                    txtAdi.Text = aANABILIMDALI.ADI;
                    if(aANABILIMDALI.ACIKLAMA != null)
                    {
                        txtAciklama.Text = aANABILIMDALI.ACIKLAMA;
                    }
                    kaydetBtn.CommandArgument = aANABILIMDALI.ANABILIMDALIID.ToString();
                    kaydetBtn.CommandName = "Düzenle";
                    kaydetBtn.Text = "Güncelle";
                }
            }
            catch (Exception ex)
            {
                sonucLbl.Text = "Hata Oluştu Tekrar Deneyiniz! " + ex.Message;
            }
        }
        

        private void veriGuncelle(int ID)
        {
            try
            {
                using (MUAYNETAKIPDBEntities dbContext = new MUAYNETAKIPDBEntities())
                {
                   ANABILIMDALI aANABILIMDALI = dbContext.ANABILIMDALI.Where(x => x.ANABILIMDALIID == ID).FirstOrDefault();
                    aANABILIMDALI.ADI = txtAdi.Text;
                    if(txtAciklama.Text != String.Empty)
                    {
                        aANABILIMDALI.ACIKLAMA = txtAciklama.Text;
                    }
                    else
                    {
                        aANABILIMDALI.ACIKLAMA = null;
                    }

                    dbContext.SaveChanges();
                    sonucLbl.Text = "Veri Güncellendi";
                }


            }
            catch (Exception ex)
            {
                sonucLbl.Text = "Hata Oluştu Tekrar Deneyiniz! " + ex.Message;
            }
            finally
            {
                veriListele();
            }
        }
    }
}