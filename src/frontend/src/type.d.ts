interface IPost {
    message: string;
}

type PostState = {
    posts: IPost[];
}

type PostAction = {
    type: string;
    post: IPost;
}

type DispatchType = (args: PostAction) => PostAction;