﻿using System.Collections.Generic;
using System.Linq;
using Nettex.Core;
using Nettex.Core.Cache;
using Nettex.Core.Entities;
using Nettex.Core.Extensions;
using Nettex.Data;

namespace Nettex.Service
{
    public class SettingService : ISettingService
    {
        #region Fields

        private readonly IRepository<Setting> settingRepository;
        private readonly ICacheManager cacheManager;

        #endregion Fields

        #region Ctor

        public SettingService(IRepository<Setting> _settingRepository, 
            ICacheManager _cacheManager)
        {
            settingRepository = _settingRepository;
            cacheManager = _cacheManager;
        }

        #endregion Ctor

        #region Methods

        public Setting GetByName(string name)
        {
            return settingRepository.Find(x => x.Name.Equals(name, System.StringComparison.InvariantCultureIgnoreCase));
        }

        public IEnumerable<Setting> GetAllSettings()
        {
            return (from p in settingRepository.Table
                    select p).ToList();
        }

        public bool Save(Setting setting)
        {
            if (setting.Id > 0)
            {
                var result = settingRepository.Update(setting);
                if (result)
                    cacheManager.Remove(CacheConstant.SETTING_ITEM.FormatInvariant(setting.Name));
                
                return result;
            }
            else
            {
                var result = settingRepository.Insert(setting);
                if (result)
                    cacheManager.Remove(CacheConstant.SETTING_ITEM.FormatInvariant(setting.Name));
                return result;
            }
        }

        public bool Delete(Setting setting)
        {
            return settingRepository.Delete(setting);
        }

        public Setting GetById(int id)
        {
            return settingRepository.Find(x => x.Id == id);
        }

        #endregion Methods
    }
}