﻿using ImageClassifier.Interfaces.GlobalUtils.Configuration;
using System;
using System.Collections.Generic;

namespace ImageClassifier.Interfaces
{
    abstract class DataSourceBase<T,I>: ConfigurationBase<T>, IDataSource where T:class, new() where I: class
    {
        #region Common Collection Information
        /// <summary>
        /// Index into CurrentImageList
        /// </summary>
        protected int CurrentImage { get; set; }
        /// <summary>
        /// List of files from the currently selected directory
        /// </summary>
        protected List<I> CurrentImageList { get; set; }
        #endregion

        public DataSourceBase(String name)
            :base(name)
        {
            this.CurrentImageList = new List<I>();
        }

        #region IDataSource
        public string Name { get; protected set; }

        public DataSourceType SourceType { get; protected set; }

        public bool DeleteSourceFilesWhenComplete { get; protected set; }

        public bool MultiClass { get; protected set; }

        public IConfigurationControl ConfigurationControl { get; protected set; }

        public IContainerControl ContainerControl { get; protected set; }

        public IImageControl ImageControl { get; protected set; }

        public IDataSink Sink { get; set; }

        public string CurrentContainer { get; protected set; }

        #region Abstracts
        public abstract IEnumerable<string> Containers { get; }

        public abstract int CurrentContainerIndex { get; }

        public abstract int CurrentContainerCollectionCount { get; }

        public abstract IEnumerable<string> CurrentContainerCollectionNames { get; }

        public abstract bool CanMovePrevious { get; }

        public abstract bool CanMoveNext { get; }

        public abstract void ClearSourceFiles();

        public abstract bool JumpToSourceFile(int idx);

        public abstract void SetContainer(string container);

        public abstract void UpdateSourceFile(SourceFile file);

        #endregion

        #endregion
    }
}