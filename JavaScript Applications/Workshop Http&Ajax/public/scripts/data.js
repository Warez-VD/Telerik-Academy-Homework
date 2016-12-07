var data = (function () {
  const USERNAME_STORAGE_KEY = 'username-key';

  // start users
  function userLogin(user) {
    localStorage.setItem(USERNAME_STORAGE_KEY, user);
    return Promise.resolve(user);
  }

  function userLogout() {
    localStorage.removeItem(USERNAME_STORAGE_KEY);
    return Promise.resolve();
  }

  function userGetCurrent() {
    return Promise.resolve(localStorage.getItem(USERNAME_STORAGE_KEY));
  }
  // end users

  // start threads
  function threadsGet() {
    return new Promise((resolve, reject) => {
      $.ajax({
        url: 'api/threads',
        method: "GET"
      })
        .done(resolve)
        .fail(reject);
    });
  }

  function threadsAdd(title) {
    return new Promise((resolve, reject) => {
      let username = userGetCurrent()
        .then(function(username){
          let body = { title, username };

          $.ajax({
            url: "api/threads",
            method: "POST",
            contentType: "application/json",
            data: JSON.stringify(body)
          }).done((data) => resolve(data))
            .fail((err) => reject(err));
        });
      });
  }

  function threadById(id) {
    return new Promise((resolve, reject) => {
            $.ajax({
              url: "api/threads/" + id,
              method: "GET"
            })
            .done(resolve)
            .fail(reject);
          });
  }

  function threadsAddMessage(threadId, content) {
    return new Promise((resolve, reject) => {
        userGetCurrent()
        .then((username) => {
          let body = {
            username: username,
            content: content
          };

            $.ajax({
              url: "api/threads/" + threadId + "/messages",
              method: "POST",
              contentType: "application/json",
              data: JSON.stringify(body)
            })
            .done(resolve)
            .fail(reject);
        });
    });
  }
  // end threads

  // start gallery
  function galleryGet() {
    const REDDIT_URL = `https://www.reddit.com/r/aww.json?jsonp=?`;
    
    return new Promise(function(resolve, reject){
      $.ajax({
        url: REDDIT_URL,
        dataType: 'jsonp'
      })
      .done(resolve)
      .fail(reject);
    });
  }
  // end gallery

  return {
    users: {
      login: userLogin,
      logout: userLogout,
      current: userGetCurrent
    },
    threads: {
      get: threadsGet,
      add: threadsAdd,
      getById: threadById,
      addMessage: threadsAddMessage
    },
    gallery: {
      get: galleryGet,
    }
  };
})();