﻿//
// Copyright  Microsoft Corporation ("Microsoft").
//
// Microsoft grants you the right to use this software in accordance with your subscription agreement, if any, to use software 
// provided for use with Microsoft Azure ("Subscription Agreement").  All software is licensed, not sold.  
// 
// If you do not have a Subscription Agreement, or at your option if you so choose, Microsoft grants you a nonexclusive, perpetual, 
// royalty-free right to use and modify this software solely for your internal business purposes in connection with Microsoft Azure 
// and other Microsoft products, including but not limited to, Microsoft R Open, Microsoft R Server, and Microsoft SQL Server.  
// 
// Unless otherwise stated in your Subscription Agreement, the following applies.  THIS SOFTWARE IS PROVIDED "AS IS" WITHOUT 
// WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL MICROSOFT OR ITS LICENSORS BE LIABLE 
// FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED 
// TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) 
// HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
// NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THE SAMPLE CODE, EVEN IF ADVISED OF THE
// POSSIBILITY OF SUCH DAMAGE.
//
using System;
using ImageClassifier.Interfaces.GlobalUtils.Configuration;
using ImageClassifier.Interfaces.GlobalUtils.Persistence;

namespace ImageClassifier.Interfaces.Source.BlobSource.Persistence
{
    /// <summary>
    /// Class used by AzureBlobSource that creates local catalogs of files found in Azure Storage.
    /// 
    /// For now this just creates random files with 100 images in each.
    /// </summary>
    class BlobPersistenceLogger : GenericCsvLogger
    {
        #region Private Members
        private AzureBlobStorageConfiguration Configuration { get; set; }
        #endregion


        public BlobPersistenceLogger(AzureBlobStorageConfiguration configuration, int fileIndex)
            :base(configuration.RecordLocation,
                String.Format("{0}{1}.csv", fileIndex.ToString(), configuration.StorageAccount),
                new string[] { "Url" })
        {
            this.Configuration = configuration;
        }

        #region Static Members
        /// <summary>
        /// Collect all catalog files for a given storage account 
        /// </summary>
        public static string[] GetAcquisitionFiles(AzureBlobStorageConfiguration configuration)
        {
            string[] fileList = new string[] { };
            if(System.IO.Directory.Exists(configuration.RecordLocation))
            {
                String filter = String.Format("*{0}.csv", configuration.StorageAccount);
                fileList = System.IO.Directory.GetFiles(configuration.RecordLocation, filter);
            }

            return fileList;
        }
        #endregion

    }
}
