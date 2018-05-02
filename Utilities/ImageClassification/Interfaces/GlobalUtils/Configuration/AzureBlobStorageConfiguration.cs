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
using System.Collections.Generic;

namespace ImageClassifier.Interfaces.GlobalUtils.Configuration
{
    /// <summary>
    /// Configuration class used for Azure Blob Storage configuration used by a data source
    /// 
    /// Corresponding control is AzureStorageConfigurationUi
    /// </summary>
    public class AzureBlobStorageConfiguration
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "classifications")]
        public List<String> Classifications { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "multiClass")]
        public bool MultiClass { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "storageAccount")]
        public String StorageAccount { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "storageKey")]
        public String StorageAccountKey { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "storageContainer")]
        public String StorageContainer { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "blobPrefix")]
        public String BlobPrefix { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "recurseDirectories")]
        public bool RecurseDirectories { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "fileType")]
        public String FileType { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "fileCount")]
        public int FileCount { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "recordLocation")]
        public string RecordLocation { get; set; }

        public AzureBlobStorageConfiguration()
        {
            this.Classifications = new List<string>();
            this.FileCount = -1;
        }
        
    }
}
