import * as actionTypes from './action-types';

export function addPost(post: IPost) {
    const action: PostAction = {
        type: actionTypes.ADD_POST,
        post
    }
    // SEND THIS TO THE REAL BACKEND
    return simulateHttpRequest(action);
}

export function simulateHttpRequest(action: PostAction) {
    return (dispatch: DispatchType) => {
      setTimeout(() => {
        dispatch(action)
      }, 500)
    }
  }