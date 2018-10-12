	
//** get image url from stored image in data base  	**//
		public string S_Pic(string sid)
        {
            con.Close();
            con.ConnectionString = sqlcs();
            con.Open();
            string iurl = "";
            byte[] imgByte = null;
            SqlDataReader sdrCN;
            SqlCommand cmdCN = new SqlCommand("select Student_Pic from ScholarRegister where SID='" + sid + "'", con);
            sdrCN = cmdCN.ExecuteReader();
            sdrCN.Read();
            imgByte = (Byte[])sdrCN["Student_Pic"];
            string base64String = Convert.ToBase64String(imgByte, 0, imgByte.Length);
            iurl = "data:image/png;base64," + base64String;
            sdrCN.Close();
            con.Close();
            return iurl;
        }
//** get image in byte from stored image in data base  	**//

        public byte[] IBS_Pic(string sid)
        {
            con.Close();
            con.ConnectionString = sqlcs();
            con.Open();
            string iurl = "";
            byte[] imgByte = null;
            SqlDataReader sdrCN;
            SqlCommand cmdCN = new SqlCommand("select Student_Pic from ScholarRegister where SID='" + sid + "'", con);
            sdrCN = cmdCN.ExecuteReader();
            sdrCN.Read();
            imgByte = (Byte[])sdrCN["Student_Pic"];
            string base64String = Convert.ToBase64String(imgByte, 0, imgByte.Length);
            iurl = "data:image/png;base64," + base64String;
            sdrCN.Close();
            con.Close();
            return imgByte;
        }
		
   //*** Convert posted file in byte and get URL after conversion  	***//
	
	public string S_Pic(HttpPostedFile File)
        {
            string iurl;
            byte[] imgByte = new Byte[File.ContentLength];
            File.InputStream.Read(imgByte, 0, File.ContentLength);
            string base64String = Convert.ToBase64String(imgByte, 0, imgByte.Length);
            iurl = "data:image/png;base64," + base64String;
            return iurl;
        }
    //** Pass Stored DB Image and get URL **//
        public string S_Pic(byte[] SchLogo)
        {
            string iurl;
            byte[] imgByte = SchLogo;
            string base64String = Convert.ToBase64String(imgByte, 0, imgByte.Length);
            iurl = "data:image/png;base64," + base64String;
            return iurl;
        }
		