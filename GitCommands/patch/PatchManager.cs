                // string retval = re.ReadToEnd();
                // GetMD5Hash(retval);
                if (!patch.Apply)
                    continue;
                string path = DirToPatch + patch.FileNameA;
                if (patch.Type == Patch.PatchType.DeleteFile)
                    File.Delete(path);
                }
                else
                {                    
                    Directory.CreateDirectory(path.Substring(0, path.LastIndexOfAny(((String)"\\/").ToCharArray())));
                    TextWriter tw = new StreamWriter(DirToPatch + patch.FileNameA, false);
                    tw.Write(patch.FileTextB);
                    tw.Close();
            byte[] bs = GetUTF8EncodedBytes(input);
            var s = new System.Text.StringBuilder();
            return s.ToString();
        }

        private byte[] GetUTF8EncodedBytes(string input)
        {
            var x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
            bs = x.ComputeHash(bs);
            return bs;
                handleDeletePatchType(patch);
            if (patch.Text == null)
                return;
            string[] patchLines = patch.Text.Split('\n');
                handleNewFilePatchType(patch, patchLines);
                handleChangeFilePatchType(patch, patchLines);
                return;
            }
        }

        private void handleChangeFilePatchType(Patch patch, string[] patchLines)
        {
            List<string> fileLines = new List<string>();
            foreach (string s in LoadFile(patch.FileNameA).Split('\n'))
            {
                fileLines.Add(s);
            }

            int lineNumber = 0;
            foreach (string line in patchLines)
            {
                //Parse fist line
                //@@ -1,4 +1,4 @@
                if (line.StartsWith("@@") && line.LastIndexOf("@@") > 0)
                    string pos = line.Substring(3, line.LastIndexOf("@@") - 3).Trim();
                    string[] addrem = pos.Split('+', '-');
                    string[] oldLines = addrem[1].Split(',');
                    string[] newLines = addrem[2].Split(',');

                    lineNumber = Int32.Parse(oldLines[0]) - 1;

                    //line = line.Substring(line.LastIndexOf("@@") + 3));
                    continue;
                if (line.StartsWith(" "))
                    //Do some extra checks
                    if (line.Length > 0)
                        if (fileLines.Count > lineNumber && fileLines[lineNumber].CompareTo(line.Substring(1)) != 0)
                            patch.Rate -= 20;
                    else
                        if (fileLines.Count > lineNumber && fileLines[lineNumber] != "")
                            patch.Rate -= 20;
                    }
                    lineNumber++;
                }
                if (line.StartsWith("-"))
                {
                    if (line.Length > 0)
                        if (fileLines.Count > lineNumber && fileLines[lineNumber].CompareTo(line.Substring(1)) != 0)
                    }
                    else
                        if (fileLines.Count > lineNumber && fileLines[lineNumber] != "")
                    }
                    patch.BookMarks.Add(lineNumber);
                    if (fileLines.Count > lineNumber)
                        fileLines.RemoveAt(lineNumber);
                    else
                        patch.Rate -= 20;

                    //lineNumber++;
                }
                if (line.StartsWith("+"))
                {
                    string insertLine = "";
                    if (line.Length > 1)
                        insertLine = line.Substring(1);

                    //Is the patch allready applied?
                    if (fileLines.Count > lineNumber && fileLines[lineNumber].CompareTo(insertLine) == 0)
                    {
                        patch.Rate -= 20;

                    fileLines.Insert(lineNumber, insertLine);
                    patch.BookMarks.Add(lineNumber);

                    lineNumber++;
            }
            foreach (string patchedLine in fileLines)
            {
                patch.FileTextB += patchedLine + "\n";
            }
            if (patch.FileTextB.Length > 0 && patch.FileTextB[patch.FileTextB.Length - 1] == '\n')
                patch.FileTextB = patch.FileTextB.Remove(patch.FileTextB.Length - 1, 1);

            if (patch.Rate != 100)
                patch.Apply = false;
        }

        private void handleNewFilePatchType(Patch patch, string[] patchLines)
        {
            foreach (string line in patchLines)
            {
                if (line.Length > 0 && line.StartsWith("+"))
                    if (line.Length > 4 && line.StartsWith("+ï»¿"))
                        patch.AppendText(line.Substring(4));
                    else
                        if (line.Length > 1)
                            patch.FileTextB += line.Substring(1);

                    patch.FileTextB += "\n";
            }
            if (patch.FileTextB.Length > 0 && patch.FileTextB[patch.FileTextB.Length - 1] == '\n')
                patch.FileTextB = patch.FileTextB.Remove(patch.FileTextB.Length - 1, 1);
            patch.Rate = 100;
            if (File.Exists(DirToPatch + patch.FileNameB))
            {
                patch.Rate -= 40;
                patch.Apply = false;
            }
        }
        private void handleDeletePatchType(Patch patch)
        {
            patch.FileTextB = "";
            patch.Rate = 100;

            if (!File.Exists(DirToPatch + patch.FileNameA))
            {
                patch.Rate -= 40;
                patch.Apply = false;
            try
            {
                StringReader stream = new StringReader(text);
                LoadPatchStream(stream, applyPatch);
        public void LoadPatchStream(TextReader reader, bool applyPatch)
           
            string input = reader.ReadLine();
            processInput(reader, input, patch);
            reader.Close();
            if (!applyPatch)
                return;

            foreach (Patch patchApply in patches)
            {
                if (patchApply.Apply)
                    ApplyPatch(patchApply);
            }
        }

        private void processInput(TextReader re, string input, Patch patch)
        {
            bool gitPatch = false;
                            if ((input = re.ReadLine()) == null)

                            patch.Apply = false;

        /// <summary>
        /// Counts number of characters on all lines in file up to line number specified.
        /// Currently doesn't check if line > lines.Length.
        /// Probably not be including newline characters in the count.
        /// Not set up to handle DOS (CR LF) line endings.
        /// 
        /// Assumes file is a text file and that line < lines.Length
        /// </summary>
        /// <param name="file">file we want to contain lines from</param>
        /// <param name="line">line number we want to count up to</param>
        /// <returns></returns>
}