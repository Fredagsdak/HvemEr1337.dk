import { ActionTypes } from './action-types';
import { CreatePostRequest } from './../shared/models/create-post-request';
import axios, { AxiosError, AxiosResponse } from 'axios';

export function addPost(post: IPost) {
  const action: PostAction = {
    type: ActionTypes.ADD_POST,
    post
  };
  return savePost(action);
}

function savePost(action: PostAction) {
  const requestBody: CreatePostRequest = {
    message: action.post.message
  };

  return (dispatch: DispatchType) => {
    axios.post('http://localhost:5000/p', requestBody).then(
      (response: AxiosResponse) => {
        console.log('response', response)
        dispatch(action);
      }
    ).catch((error: AxiosError) => {
      console.log('error', error.message);
    });
  }
}