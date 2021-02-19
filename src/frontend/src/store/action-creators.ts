import { ActionTypes } from './action-types';
import { CreatePostRequest } from './../shared/models/create-post-request';
import axios, { AxiosError, AxiosResponse } from 'axios';

export function addPost(post: IPost) {
  const action: PostAction = {
    type: ActionTypes.ADD_POST,
    posts: [post]
  };
  return savePost(action);
}

export function getAllPosts() {
  return (dispatch: DispatchType) => {
    axios.get<IPost[]>('http://localhost:5000/p').then(
      (response: AxiosResponse) => {
        console.log('getAllPostsResponse', response);
        const action: PostAction = {
          type: ActionTypes.GET_ALL_POSTS,
          posts: response.data
        };
        dispatch(action);
      }
    );
  };
};

function savePost(action: PostAction) {
  const requestBody: CreatePostRequest = {
    message: action.posts[0].message
  };

  return (dispatch: DispatchType) => {
    axios.post('http://localhost:5000/p', requestBody).then(
      (response: AxiosResponse) => {
        console.log('savePostResponse', response);
        dispatch(action);
      }
    ).catch((error: AxiosError) => {
      console.log('error', error.message);
    });
  }
}