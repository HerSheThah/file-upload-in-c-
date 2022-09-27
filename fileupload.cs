 private string UploadFile(ProductVM productVM)
        {
            string filename = null;
            if (productVM.image != null)
            {
                string uploadDir = Path.Combine(webHostEnvironment.WebRootPath, "Images");
                filename = Guid.NewGuid().ToString() + "-" + productVM.image.FileName;
                string filePath = Path.Combine(uploadDir, filename);
                using (var filstream = new FileStream(filePath, FileMode.Create))
                {
                    productVM.image.CopyTo(filstream);
                }
            }
            return filename;
        }
